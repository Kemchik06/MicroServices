using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProductUser.Microservice.Model;

namespace ProductUser.Microservice.Data
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

        public DbSet<ProductOfferDetail> ProductOffers { get; set; }
    }
}
