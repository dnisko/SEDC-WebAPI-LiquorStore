using AutoMapper;
using DomainModels;
using DTOs;
using DTOs.User;

namespace Mappers
{

    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            /*
            CreateMap<User, UserWithInfoDto>()
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Username, opt => opt.MapFrom(src => src.Username))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.ConfirmedEmail, opt => opt.MapFrom(src => src.ConfirmedEmail))

                .ForMember(dest => dest.FirstName, opt => opt.Ignore()) // will be set from UserInfo
                .ForMember(dest => dest.LastName, opt => opt.Ignore()) // will be set from UserInfo
                .ForMember(dest => dest.Street, opt => opt.Ignore()) // will be set from UserInfo
                .ForMember(dest => dest.City, opt => opt.Ignore()) // will be set from UserInfo
                .ForMember(dest => dest.Country, opt => opt.Ignore()); // will be set from UserInfo

            CreateMap<UserInfo, UserWithInfoDto>()
                .ForMember(dest => dest.UserId, opt => opt.Ignore())
                .ForMember(dest => dest.Username, opt => opt.Ignore())
                .ForMember(dest => dest.Email, opt => opt.Ignore())
                .ForMember(dest => dest.ConfirmedEmail, opt => opt.Ignore())

                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
                .ForMember(dest => dest.Street, opt => opt.MapFrom(src => src.Street))
                .ForMember(dest => dest.City, opt => opt.MapFrom(src => src.City))
                .ForMember(dest => dest.Country, opt => opt.MapFrom(src => src.Country));

            //// Map User to UserDto
            //CreateMap<User, UserDto>()
            //    .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.Username));

            //// Map UserInfo to UserDto (combining data from UserInfo into UserDto)
            //CreateMap<UserInfo, UserDto>()
            //    .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
            //    .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName));

            //// Map User and UserInfo to UserWithInfoDto
            //CreateMap<User, UserWithInfoDto>()
            //    .ForMember(dest => dest.Username, opt => opt.MapFrom(src => src.Username))
            //    .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
            //    .ForMember(dest => dest.ConfirmedEmail, opt => opt.MapFrom(src => src.ConfirmedEmail));

            //CreateMap<UserInfo, UserWithInfoDto>()
            //    .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
            //    .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
            //    .ForMember(dest => dest.Street, opt => opt.MapFrom(src => src.Street))
            //    .ForMember(dest => dest.City, opt => opt.MapFrom(src => src.City))
            //    .ForMember(dest => dest.Country, opt => opt.MapFrom(src => src.Country));

            //// Optionally, map LoginDto to User if needed (but reverse mapping is usually unnecessary here)
            //CreateMap<LoginDto, User>()
            //    .ForMember(dest => dest.Username, opt => opt.MapFrom(src => src.Username))
            //    .ForMember(dest => dest.Password, opt => opt.Ignore()); // Password should be hashed separately
            */
        }
    }

}
