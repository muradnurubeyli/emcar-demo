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
        public async Task<IActionResult> Create(AuctionCreateVM modelVM, bool activate = false)
        {
            //User user = UserService.GetUserByEmail(User.Identity.Name);
            //Auto auto = user?.Autoes.FirstOrDefault(a => a.ID == modelVM.AutoID);
            //if (auto == null || auto.InAuction)
            //    return HttpNotFound();

            Auction auction = await _auctionRepository.GetByIdAsync(modelVM.ID);

            //decimal summ = _billingService.GeneratePriceForAuctionPublishing(modelVM.Days, modelVM.Hours);

            //first reliz
            //int days = XCarsConfiguration.AuctionDaysDuration;
            //int hours = XCarsConfiguration.AuctionHoursDuration;

            AuctionPublishModel auctioVM = new AuctionPublishModel
            {
                AutoId = modelVM.AutoID,
                CurrencyID = modelVM.CurrencyID,
                CurrentPrice = 100,
                Days = modelVM.Days,
                Hours = modelVM.Hours,
                StartPrice = modelVM.StartPrice,
                Description = modelVM.Description,
                AuctionId = auction.Id,
                Deadline = auction.Deadline
            };

            auction.Description = modelVM.Description;
            auction.StartPrice = modelVM.StartPrice;
            auction.CurrencyID = modelVM.CurrencyID;

            _auctionRepository.Update(auction);
            activate = auction.Deadline > DateTime.Now ? true : false;

            return Ok("Created");
        }
    }
}
