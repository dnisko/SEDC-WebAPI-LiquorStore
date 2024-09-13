using DomainModels;

namespace DataAccess.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        User loginUser(string username, string hashPassword);
    }
}
