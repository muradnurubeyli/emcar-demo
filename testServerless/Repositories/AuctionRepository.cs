using testServerless.Context;
using testServerless.Models;

namespace testServerless.Repositories
{
    public class AuctionRepository : GenericRepository<Auto>, IAutoRepository
    {
        public AuctionRepository(EmcarContext dbContext) : base(dbContext)
        {
        }
    }
}
