namespace DomainModels
{
    public abstract class BaseClass
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public int CreatedBy { get; set; } = 1;
        public DateTime ModifiedOn { get; set; } = DateTime.Now;
        public int ModifiedBy { get; set; } = 1;
        public DateTime DeletedOn { get; set; }
        public int DeletedBy { get; set; }
    }
}
