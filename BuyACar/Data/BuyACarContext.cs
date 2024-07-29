

using BuyACar.Models;
using Microsoft.EntityFrameworkCore;

namespace BuyACar.Data
{
    public class BuyACarContext : DbContext
    {
        public BuyACarContext(DbContextOptions<BuyACarContext> options)
            : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; } = null!;
    }


}
