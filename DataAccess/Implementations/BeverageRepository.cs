using System.Security.Cryptography.X509Certificates;
using DataAccess.Interfaces;
using DomainModels;

namespace DataAccess.Implementations
{
    public class BeverageRepository : Repository<Beverage>, IBeverageRepository
    {
        private readonly LiquorStoreDbContext _context;

        public BeverageRepository(LiquorStoreDbContext context) : base(context)
        {
            _context = context;
        }

        public List<Beverage> GetByType(int type)
        {
            var typeCount = _context.Beverages.Select(x => x.Type).Distinct().Count();
            if (type < 0 || type > typeCount)
            {
                throw new IndexOutOfRangeException($"Please enter number between 0 and {typeCount}");
            }

            return _context.Beverages.Where(x => (int)x.Type == type).ToList();
        }
    }
}
