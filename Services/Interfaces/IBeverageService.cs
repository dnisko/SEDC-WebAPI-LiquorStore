using DTOs.Beverage;

namespace Services.Interfaces
{
    public interface IBeverageService
    {
        List<BeverageDto> GetAllBeverages();
        BeverageDto GetBeverageById(int id);
        AddBeverageDto AddBeverage(AddBeverageDto beverage, int userId);
        int UpdateBeverage(AddBeverageDto beverage, int id);
        int DeleteBeverage(int id);
        List<BeverageDto> GetBeveragesByType(int type);
    }
}
