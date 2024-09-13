using DomainModels.Enums;

namespace DTOs.Beverage
{
    public class AddBeverageDto
    {
        public string Name { get; set; }
        public BeverageType Type { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
