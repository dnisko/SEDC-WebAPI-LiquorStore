using DTOs.Beverage;

namespace Services.Interfaces
{
    public interface IBeverageService
    {
        AddBeverageDto AddBeverage(AddBeverageDto beverage, int userId);
    }
}
