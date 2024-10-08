﻿using DataAccess.Interfaces;
using DomainModels;
using Microsoft.IdentityModel.Tokens;
using Services.Interfaces;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using AutoMapper;
using DTOs.User;
using Mappers;
using Microsoft.Extensions.Options;
using Services.Helpers;

namespace Services.Implementation
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IUserInfoRepository _userInfoRepository;
        private readonly IOptions<AppSettings> _appOptions;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository,
            IUserInfoRepository userInfoRepository,
            IOptions<AppSettings> appOptions,
            IMapper mapper)
        {
            _userRepository = userRepository;
            _userInfoRepository = userInfoRepository;
            _appOptions = appOptions;
            _mapper = mapper;
        }

        /*
        public string LoginUser(string userName, string password)
        {
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                throw new Exception("Username and password must be provided!");
            }

            var md5CryptoService = MD5.Create();
            byte[] passwordBytes = Encoding.ASCII.GetBytes(password);

            byte[] hashByte = md5CryptoService.ComputeHash(passwordBytes);

            string hashPassword = Encoding.ASCII.GetString(hashByte);


            var loginUser = _userRepository.loginUser(userName, hashPassword);
            var user = _userInfoRepository.GetById(loginUser.Id);

            if (user == null)
            {
                throw new Exception("User not found!");
            }

            var tokenHandler = new JwtSecurityTokenHandler();
            byte[] secretKeyBytes = Encoding.ASCII.GetBytes("secretKeyForAuthentication.DoNotFail");

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(secretKeyBytes), 
                    SecurityAlgorithms.HmacSha256Signature),

                Subject = new ClaimsIdentity(
                    new[]
                    {
                        new Claim(ClaimTypes.Name, loginUser.Username),
                        new Claim("User", $"{loginUser.Username}")
                    })
            };

            SecurityToken token = tokenHandler.CreateToken(tokenDescriptor);
            //tokenHandler.WriteToken(token);
            return tokenHandler.WriteToken(token);
            //return loginUser;
        }
        */
        /*
        public string LoginUser(string userName, string password)
        {
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                throw new Exception("Username and password must be provided!");
            }

            using (var sha256 = SHA256.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256.ComputeHash(passwordBytes);
                string hashPassword = Convert.ToBase64String(hashBytes);

                var loginUser = _userRepository.loginUser(userName, hashPassword);
                if (loginUser == null)
                {
                    throw new Exception("User not found!");
                }

                var user = _userInfoRepository.GetById(loginUser.Id);
                if (user == null)
                {
                    throw new Exception("User information not found!");
                }

                var tokenHandler = new JwtSecurityTokenHandler();
                var secretKeyBytes = Encoding.ASCII.GetBytes("secretKeyForAuthentication.DoNotFail");
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Expires = DateTime.UtcNow.AddHours(1),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(secretKeyBytes), SecurityAlgorithms.HmacSha256),
                    Subject = new ClaimsIdentity(new[]
                    {
                        new Claim(ClaimTypes.Name, loginUser.Username),
                        new Claim(ClaimTypes.NameIdentifier, loginUser.Id.ToString())
                    })
                };

                var token = tokenHandler.CreateToken(tokenDescriptor);
                return tokenHandler.WriteToken(token);
            }
        }
        */
        public UserWithInfoDto LoginUser(LoginDto loginUser)
        {
            if (string.IsNullOrEmpty(loginUser.Username) || string.IsNullOrEmpty(loginUser.Password))
            {
                throw new Exception("Username and password must be provided!");
            }

            var hashedPassword = HashPassword(loginUser.Password);
            var user = _userRepository.LoginUser(loginUser.Username, hashedPassword);
            if (user == null)
            {
                throw new Exception("User not found!");
            }

            var userInfo = _userInfoRepository.GetById(user.Id);
            if (userInfo == null)
            {
                throw new Exception("User information not found!");
            }

            var userWithInfoDto = user.ToUserWithInfoDto(userInfo);
            userWithInfoDto.Token = GenerateToken(user);

            return userWithInfoDto;
        }

        public UserWithInfoDto RegisterUser(RegisterUserDto registerUser)
        {
            if (string.IsNullOrEmpty(registerUser.Username) &&
                string.IsNullOrEmpty(registerUser.Password))
            {
                throw new Exception("Username and password must be provided!");
            }

            ValidateUser(registerUser);
            var hashedPassword = HashPassword(registerUser.Password);
            registerUser.Password = hashedPassword;
            registerUser.ConfirmPassword = hashedPassword;

            User user = new User
            {
                //FirstName = registerUser.Username,
                //LastName = registerUser.LastName,
                Username = registerUser.Username,
                Email = registerUser.Email,
                Password = hashedPassword
            };
            _userRepository.Add(user);

            UserInfo userInfo = new UserInfo
            {
                UserId = user.Id,
                FirstName = registerUser.FirstName,
                LastName = registerUser.LastName
            };
            _userInfoRepository.Add(userInfo);

            var returnUser = new UserWithInfoDto
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

            return returnUser;
        }

        public UserWithInfoDto EditUser(UserWithInfoDto editUser, string username)
        {
            var user = _userRepository.GetByUsername(username);
            if (user == null)
            {
                throw new Exception("User not found.");
            }
            var userInfo = _userInfoRepository.GetById(user.Id);


            user.Username = editUser.Username;
            user.Email = editUser.Email;
            user.ConfirmedEmail = editUser.ConfirmedEmail;

            userInfo.FirstName = editUser.FirstName;
            userInfo.LastName = editUser.LastName;
            userInfo.Street = editUser.Street;
            userInfo.City = editUser.City;
            userInfo.Country = editUser.Country;

            _userRepository.Update(user);
            _userInfoRepository.Update(userInfo);

            return editUser;
        }

        public int MakeAdmin(string username)
        {
            var user = _userRepository.GetByUsername(username);
            if (user == null)
                throw new Exception("User not found");
            user.IsAdmin = true;
            _userRepository.Update(user);
            return user.Id;
        }

        private static void ValidateUser(RegisterUserDto user)
        {
            if (user.Password != user.ConfirmPassword)
                throw new Exception("Password did not match.");
        }

        private static string HashPassword(string password)
        {
            MD5 md5CryptoServiceProvider = MD5.Create();
            byte[] passwordBytes = Encoding.ASCII.GetBytes(password);
            byte[] hashBytes = md5CryptoServiceProvider.ComputeHash(passwordBytes);
            string hashedPassword = Encoding.ASCII.GetString(hashBytes);

            return hashedPassword;
        }

        private string GenerateToken(User user)
        {
            var userInfo = _userInfoRepository.GetById(user.Id);
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            byte[] secretKeyBytes = Encoding.ASCII.GetBytes("this is my custom Secret key for authentication");

            SecurityTokenDescriptor tokenDescriptor = new SecurityTokenDescriptor
            {
                Expires = DateTime.UtcNow.AddMinutes(60),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(secretKeyBytes),
                    SecurityAlgorithms.HmacSha256Signature),
                Subject = new ClaimsIdentity(
                    new[]
                    {
                        new Claim(ClaimTypes.Name, user.Username),
                        new Claim("userFullName", $"{userInfo.FirstName} {userInfo.LastName}"),
                        new Claim("IsAdmin", user.IsAdmin.ToString())
                    })
            };
            SecurityToken token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
    }
}
