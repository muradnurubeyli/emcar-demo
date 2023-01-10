using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Nest;
using testServerless.Models;
using testServerless.Repositories;
using testServerless.ViewModel;

namespace testServerless.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutoController : ControllerBase
    {
        private readonly IAutoRepository _autoRepository;
        private readonly IMapper _mapper;
        private readonly IElasticClient _elasticClient;
        private readonly ILogger<AutoController> _logger;

        public AutoController(IAutoRepository autoRepository, IMapper mapper, IElasticClient elasticClient, ILogger<AutoController> logger)
        {
            _autoRepository = autoRepository;
            _mapper = mapper;
            _logger = logger;
            _elasticClient = elasticClient;
        }

        //[HttpGet]
        //public async Task<IActionResult> GetAutoWithKeyWord(string keyword)
        //{
        //    //var result = await _elasticClient.SearchAsync<Auto>(
        //    //                 s => s.Query(
        //    //                     q => q.QueryString(
        //    //                         d => d.Query('*' + keyword + '*')
        //    //                     )).Size(5000));
        //    _logger.LogInformation("AutoController Get - ", DateTime.UtcNow);

        //    var response = await _elasticClient.Indices.GetAliasAsync();
        //    string test = "";
        //    foreach (var index in response.Indices)
        //    {
        //        test += index.Key.ToString();
        //    }

        //    //return Ok(result.Documents.ToList());
        //    return Ok(test);
        //}

        [HttpGet]
        [Route("get-all-auto")]
        public async Task<IActionResult> GetAutos()
        {
            var autos = await _autoRepository.GetAll();
            var autoResource = _mapper.Map<IEnumerable<Auto>, IEnumerable<GetAutoViewModel>>(autos);

            return Ok(autoResource);
        }

        [HttpPost]
        [Route("create-auto")]
        public IActionResult CreateAuto([FromBody] CreateAutoViewModel command, int paymentDay)
        {
            if (command == null)
            {
                return BadRequest();
            }

            command.DateExpires = DateTime.Now.AddDays(paymentDay);
            Auto auto = _mapper.Map<CreateAutoViewModel, Auto>(command);
            _autoRepository.Add(auto);

            // Index product dto
            _elasticClient.IndexDocumentAsync(auto);
            _logger.LogInformation("AutoController Get - ", DateTime.UtcNow);

            return Ok(command);
        }

        [HttpPut]
        [Route("update-expired-car")]
        public async Task<IActionResult> UpdateExpiredCar()
        {
            var first = await _autoRepository.GetByIdAsync(1);
            var cars = await _autoRepository.GetAll();

            foreach (var item in cars.Where(i => i.IsActive == true))
            {
                if (item.DateExpires < DateTime.Now)
                {
                    item.IsActive = false;
                    await _autoRepository.UpdateAsync(item);
                }
            }

            return Ok();
        }

        [HttpPut]
        [Route("update-car/{id}")]
        public IActionResult UpdateCar(int id, [FromBody] UpdateAutoViewModel resource, int paymentDay)
        {
            if (!ModelState.IsValid) return BadRequest();
            if (id != resource.Id) return NotFound();

            resource.DateExpires = DateTime.Now.AddDays(paymentDay);
            var resourceToModel = _mapper.Map<UpdateAutoViewModel, Auto>(resource);
            var auto = _autoRepository.Update(resourceToModel);

            if (resourceToModel == null) return NotFound();

            // Index product dto
            //_elasticClient.IndexDocumentAsync(auto);
            _logger.LogInformation("AutoController Get - ", DateTime.UtcNow);

            return Ok(auto);
        }

        [HttpDelete]
        [Route("delete-car/{id}")]
        public async Task<IActionResult> DeleteDeviceMake(int id)
        {
            var auto = await _autoRepository.GetByIdAsync(id);
            if (auto == null) return NotFound();
            _autoRepository.Delete(id);

            return Ok("Car Deleted");
        }
    }
}
