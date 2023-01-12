using testServerless.Context;
using testServerless.Models;

namespace testServerless.Repositories
{
    public class AuctionRepository : GenericRepository<Auction>, IAuctionRepository
    {
        public AuctionRepository(EmcarContext dbContext) : base(dbContext)
        {
        }
    }
}
