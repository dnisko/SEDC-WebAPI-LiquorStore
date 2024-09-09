using DomainModels.Enums;

namespace DomainModels
{
    public class Beverage : BaseClass
    {
        public string Name { get; set; }
        public BeverageType Type { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
