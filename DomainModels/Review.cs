using DomainModels.Enums;

namespace DomainModels
{
    public class Review : BaseClass
    {
        public int BeverageId { get; set; }
        public Beverage Beverage { get; set; }
        public int UserId  { get; set; }
        public User User { get; set; }
        public Rating Rating { get; set; }
        public string Comment { get; set; }
    }
}
