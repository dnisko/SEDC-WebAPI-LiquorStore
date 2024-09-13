using DomainModels;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class LiquorStoreDbContext : DbContext
    {
        public LiquorStoreDbContext(DbContextOptions<LiquorStoreDbContext> options) : base(options)
        {

        }

        public DbSet<UserInfo> UserInfo { get; set; }
        public DbSet<Beverage> Beverages { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Payment> Payment { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            PopulateDb.Seed(builder);
        }
    }
}
