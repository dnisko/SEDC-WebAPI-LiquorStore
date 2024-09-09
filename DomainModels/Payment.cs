using DomainModels.Enums;

namespace DomainModels
{
    public class Payment : BaseClass
    {
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public decimal Amount { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public Status Status { get; set; }
    }
}
