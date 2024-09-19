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

        public List<BeverageDto> GetAllBeverages()
        {
            //throw new NotImplementedException();
;            var beverages = _beverageRepository.GetAll();
            return beverages.Select(x => x.ToBeverageDto()).ToList();
        }

        public BeverageDto GetBeverageById(int id)
        {
            //throw new NotImplementedException();
            return _beverageRepository.GetById(id).ToBeverageDto();
        }

        public AddBeverageDto AddBeverage(AddBeverageDto beverage, int userId)
        {
            var user = _userRepository.GetById(userId);

            if (user == null || !user.IsAdmin)
            {
                throw new UnauthorizedAccessException("You do not have permission to add a beverage.");
            }
            //throw new NotImplementedException();
            _beverageRepository.Add(beverage.ToModel());
            return beverage;
        }

        public int UpdateBeverage(AddBeverageDto beverage, int id)
        {
            var existingBeverage = _beverageRepository.GetById(id);
            if (existingBeverage == null)
            {
                return 0;
            }
            existingBeverage.Name = beverage.Name;
            existingBeverage.Description = beverage.Description;
            existingBeverage.Quantity = beverage.Quantity;
            existingBeverage.ImageUrl = beverage.ImageUrl;
            existingBeverage.Price = beverage.Price;
            existingBeverage.Type = beverage.Type;
            existingBeverage.ModifiedOn = DateTime.Now;

            return existingBeverage.Id;
        }

        public int DeleteBeverage(int id)
        {
            var existingBeverage = _beverageRepository.GetById(id);
            if (existingBeverage != null)
                _beverageRepository.Remove(id);
            return 1;
        }
    }
}
