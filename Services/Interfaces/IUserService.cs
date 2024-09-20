using DomainModels;
using DTOs.User;

namespace Services.Interfaces
{
    public interface IUserService
    {
        UserWithInfoDto RegisterUser(RegisterUserDto user);
        UserWithInfoDto LoginUser(LoginDto loginUser);
        UserWithInfoDto EditUser(UserWithInfoDto editUser, string username);
        public int MakeAdmin(string username);
    }
}
