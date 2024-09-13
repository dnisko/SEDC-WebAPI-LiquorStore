using System.Security.Cryptography.X509Certificates;
using DataAccess.Interfaces;
using DTOs.Beverage;
using Mappers;
using Services.Interfaces;

namespace Services.Implementation
{
    public class BeverageService : IBeverageService
    {
        private readonly IUserRepository _userRepository;
        private readonly IBeverageRepository _beverageRepository;

        public BeverageService(IUserRepository userRepository, IBeverageRepository beverageRepository)
        {
            _userRepository = userRepository;
            _beverageRepository = beverageRepository;
        }

        public AddBeverageDto AddBeverage(AddBeverageDto beverage, int userId)
        {
            var user = _userRepository.GetById(userId);

            if (user == null || !user.IsAdmin)
            {
                throw new UnauthorizedAccessException("You do not have permission to add a beverage.");
            }
            _beverageRepository.Add(beverage.ToModel());
            return beverage;
        }
    }
}
