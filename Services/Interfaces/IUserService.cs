using DTOs;
using DTOs.User;

namespace Services.Interfaces
{
    public interface IUserService
    {
        UserWithInfoDto RegisterUser(RegisterUserDto user);
        string LoginUser(string userName, string password);
    }
}
