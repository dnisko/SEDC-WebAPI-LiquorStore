using DomainModels;
using DTOs.Beverage;

namespace Mappers
{
    public static class BeverageMappers
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

        public static AddBeverageDto ToAddBeverageDto(this Beverage beverage)
        {
            return new AddBeverageDto
            {
                Name = beverage.Name,
                Description = beverage.Description,
                ImageUrl = beverage.ImageUrl,
                Price = beverage.Price,
                Quantity = beverage.Quantity,
                Type = beverage.Type
            };
        }

        public static Beverage ToModel(this BeverageDto beverageDto)
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

        public static BeverageDto ToBeverageDto(this Beverage beverage)
        {
            return new BeverageDto
            {
                Name = beverage.Name,
                Description = beverage.Description,
                ImageUrl = beverage.ImageUrl,
                Price = beverage.Price,
                Quantity = beverage.Quantity,
                Type = beverage.Type
            };
        }
    }
}
