using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProductOwner.Microservice.Model;

namespace ProductOwner.Microservice.Data
{
    public class DbContextClass : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DbContextClass(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<ProductDetails> Products { get; set; }
    }
}
