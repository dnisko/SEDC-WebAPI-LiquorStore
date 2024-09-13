using DomainModels;
using DTOs.Beverage;

namespace Mappers
{
    public static class AddBeverageToModel
    {
        public static Beverage ToModel(this AddBeverageDto beverageDto)
        {
            return new Beverage
            {
                Name = beverageDto.Name,
                Description = beverageDto.Description,
                ImageUrl = beverageDto.ImageUrl,
                Price = beverageDto.Price,
                Quantity = beverageDto.Quantity,
                Type = beverageDto.Type
            };
        }
    }
}
