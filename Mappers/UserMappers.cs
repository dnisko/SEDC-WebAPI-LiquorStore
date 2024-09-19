using System.Runtime.CompilerServices;
using DomainModels;
using DTOs.Beverage;
using DTOs.User;

namespace Mappers
{
    public static class UserMappers
    {
        public static User ToUserModel(this UserWithInfoDto userDto)
        {
            return new User
            {
                Id = userDto.UserId,
                Username = userDto.Username,
                Email = userDto.Email,
                ConfirmedEmail = userDto.ConfirmedEmail
            };
        }
        public static UserWithInfoDto ToUserWithInfoDto(this User user, UserInfo userInfo)
        {
            return new UserWithInfoDto
            {
                UserId = user.Id,
                Username = user.Username,
                Email = user.Email,
                ConfirmedEmail = user.ConfirmedEmail,

                FirstName = userInfo.FirstName,
                LastName = userInfo.LastName,
                Street = userInfo.Street,
                City = userInfo.City,
                Country = userInfo.Country
            };
        }
    }
}
