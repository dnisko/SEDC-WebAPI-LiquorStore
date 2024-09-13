using DataAccess.Interfaces;
using DomainModels;

namespace DataAccess.Implementations
{
    public class BeverageRepository : Repository<Beverage>, IBeverageRepository
    {
        public BeverageRepository(LiquorStoreDbContext context) : base(context)
        {

        }
    }
}
