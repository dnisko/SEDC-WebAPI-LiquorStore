namespace DomainModels
{
    public class Cart : BaseClass
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int BeverageId { get; set; }
        public Beverage Beverage { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
