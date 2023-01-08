using testServerless.Context;
using testServerless.Models;

namespace testServerless.Repositories
{
    public class AutoRepository : GenericRepository<Auto>, IAutoRepository
    {
        public AutoRepository(EmcarContext dbContext) : base(dbContext)
        {
        }
    }
}
