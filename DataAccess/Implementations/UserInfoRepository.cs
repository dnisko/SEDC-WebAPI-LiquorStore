using DataAccess.Interfaces;
using DomainModels;

namespace DataAccess.Implementations
{
    public class UserInfoRepository : Repository<UserInfo>, IUserInfoRepository
    {
        //private readonly LiquorStoreDbContext _context;

        public UserInfoRepository(LiquorStoreDbContext context) : base(context)
        {
            //_context = context;
        }


    }
}
