using DataAccess;
using DataAccess.Implementations;
using DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Workshop.E_Shop.Services.Helpers
{
    public static class DiModule
    {
        public static IServiceCollection RegisterDbContext(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<LiquorStoreDbContext>(options =>
                options.UseSqlServer(connectionString));

            return services;
        }

        public static IServiceCollection RegisterRepositories(this IServiceCollection services, string connectionString)
        {
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
            //services.AddTransient<ICategoryRepository, CategoryRepository>();
            //services.AddTransient<IProductRepository, ProductRepository>();
            ////services.AddTransient<IRepository<Category>>(x => new CategoryAdoRepository(connectionString));
            //services.AddTransient<IRepository<Category>>(x => new CategoryDapperRepository(connectionString));
            //services.AddTransient<IUserRepository, UserRepository>();
            return services;
        }
    }
}