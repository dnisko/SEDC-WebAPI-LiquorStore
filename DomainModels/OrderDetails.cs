namespace DomainModels
{
    public class OrderDetails : BaseClass
    {
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int BeverageId { get; set; }
        public Beverage Beverage { get; set; }
        public int Quantity { get; set; }
        public decimal PricePerUnit { get; set; }
        public decimal TotalPrice => Quantity * PricePerUnit;
    }
}
