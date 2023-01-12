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
    public class AuctionController : ControllerBase
    {
        private readonly IAuctionRepository _auctionRepository;
        private readonly IMapper _mapper;
        private readonly IElasticClient _elasticClient;
        private readonly ILogger<AutoController> _logger;

        public AuctionController(IAuctionRepository auctionRepository, IMapper mapper, IElasticClient elasticClient, ILogger<AutoController> logger)
        {
            _auctionRepository = auctionRepository;
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

        [HttpPost]
        [Route("create-auction")]
        public async Task<IActionResult> Create([FromBody] AuctionCreateVM command, bool activate = false)
        {
            if (command == null)
            {
                return BadRequest();
            }

            Auction auction = _mapper.Map<AuctionCreateVM, Auction>(command);
            await _auctionRepository.AddAsync(auction);

            // Index product dto
            //await _elasticClient.IndexDocumentAsync(auction);
            _logger.LogInformation("AuctionController Get - ", DateTime.UtcNow);
            activate = command.Deadline > DateTime.Now ? true : false;

            return Ok(command);
        }

        [HttpPut]
        [Route("update-auction/{id}")]
        public IActionResult UpdateCar(int id, [FromBody] UpdateAuctionViewModel resource)
        {
            if (!ModelState.IsValid) return BadRequest();
            if (id != resource.Id) return NotFound();

            var resourceToModel = _mapper.Map<UpdateAuctionViewModel, Auction>(resource);
            var auto = _auctionRepository.Update(resourceToModel);

            if (resourceToModel == null) return NotFound();

            // Index product dto
            //_elasticClient.IndexDocumentAsync(auto);
            _logger.LogInformation("AuctionController Get - ", DateTime.UtcNow);

            return Ok(auto);
        }

        [HttpDelete]
        [Route("delete-auction/{id}")]
        public async Task<IActionResult> DeleteAuction(int id)
        {
            var auction = await _auctionRepository.FirstOrDefaultAsync(i => i.Id == id);
            auction.StatusID = 2;
            if (auction == null) return NotFound();
            _auctionRepository.Update(auction);

            return Ok("Auction Deactivated");
        }
    }
}
