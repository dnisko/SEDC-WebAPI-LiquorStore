using DataAccess.Interfaces;
using DomainModels;
using Microsoft.IdentityModel.Tokens;
using Services.Interfaces;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using DTOs;
using DTOs.User;

namespace Services.Implementation
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IUserInfoRepository _userInfoRepository;

        public UserService(IUserRepository userRepository, IUserInfoRepository userInfoRepository)
        {
            _userRepository = userRepository;
            _userInfoRepository = userInfoRepository;
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
        public string LoginUser(string userName, string password)
        {
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                throw new Exception("Username and password must be provided!");
            }

            using (var md5CryptoService = MD5.Create())
            {
                byte[] passwordBytes = Encoding.ASCII.GetBytes(password);

                byte[] hashByte = md5CryptoService.ComputeHash(passwordBytes);

                string hashPassword = Encoding.ASCII.GetString(hashByte);

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
        public UserWithInfoDto RegisterUser(RegisterUserDto registerUser)
        {
            if (string.IsNullOrEmpty(registerUser.Username) &&
                string.IsNullOrEmpty(registerUser.Password))
            {
                throw new Exception("Username and password must be provided!");
            }

            var md5CryptoService = MD5.Create();
            byte[] passwordBytes = Encoding.ASCII.GetBytes(registerUser.Password);

            byte[] hashByte = md5CryptoService.ComputeHash(passwordBytes);

            string hashPassword = Encoding.ASCII.GetString(hashByte);

            User user = new User
            {
                //FirstName = registerUser.Username,
                //LastName = registerUser.LastName,
                Username = registerUser.Username,
                Email = registerUser.Email,
                Password = hashPassword
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
    }
}
