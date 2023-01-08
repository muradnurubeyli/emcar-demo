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


        [HttpGet]
        public async Task<IActionResult> Get(string keyword)
        {
            var result = await _elasticClient.SearchAsync<Auto>(
                             s => s.Query(
                                 q => q.QueryString(
                                     d => d.Query('*' + keyword + '*')
                                 )).Size(5000));

            _logger.LogInformation("AutoController Get - ", DateTime.UtcNow);
            return Ok(result.Documents.ToList());
        }

        //[HttpGet]
        //public async Task<IActionResult> Get()
        //{
        //    return Ok(await _autoRepository.GetAll());
        //}

        [HttpPost]
        public IActionResult CreateTask([FromBody] CreateAutoViewModel command, int paymentDay)
        {
            if (command == null)
            {
                return BadRequest();
            }

            // Add product to ELS index
            //var product1 = new Product
            //{
            //    Description = "Product 1",
            //    Id = 1,
            //    Price = 200,
            //    Measurement = "2",
            //    Quantity = 90,
            //    ShowPrice = true,
            //    Title = "Nike Shoes",
            //    Unit = "10"
            //};

            // Index product dto
            command.DateExpires = DateTime.Now.AddMinutes(paymentDay);
            Auto auto = _mapper.Map<CreateAutoViewModel, Auto>(command);

            _autoRepository.Add(auto);
            _elasticClient.IndexDocumentAsync(auto);

            _logger.LogInformation("AutoController Get - ", DateTime.UtcNow);
            return Ok(command);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCar()
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
    }
}
