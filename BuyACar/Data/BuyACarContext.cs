

using BuyACar.Models;
using BuyACar.Models.Car;
using Microsoft.EntityFrameworkCore;

namespace BuyACar.Data
{
    public class BuyACarContext : DbContext
    {
        public BuyACarContext(DbContextOptions<BuyACarContext> options)
            : base(options)
        {
        }

        
        public DbSet<Manufacturer> Manufacturer { get; set; } = null!;
        public DbSet<CarModel> CarModels { get; set; } = null!;
        public DbSet<Car> Cars { get; set; } = null!;

       /* protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.
        }*/
    }
     

}
