namespace DomainModels
{
    public class Order : BaseClass
    {
        public int UserId { get; set; }
        public User User { get; set; }
        //public DateTime OrderDate { get; set; } = DateTime.Now;
        public decimal TotalPrice { get; set; }
        public ICollection<OrderDetails> OrderDetails { get; set; } = new List<OrderDetails>();

        public void UpdateTotalPrice()
        {
            TotalPrice = OrderDetails.Sum(x => x.TotalPrice);
        }
    }
}
