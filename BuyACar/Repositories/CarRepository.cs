using BuyACar.Data;
using BuyACar.Models.Car;
using Microsoft.EntityFrameworkCore;

namespace BuyACar.Repositories
{
    public class CarRepository : ICarRepository
    {

        private readonly BuyACarContext Context;

        public CarRepository(BuyACarContext context)
        {
            this.Context = context;
        }

        public async Task<Car?> GetCarByIdAsync(int id)
        {
            return await Context.Cars
                .Include(c => c.CarModel)
                .ThenInclude(cm => cm.Manufacturer)
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        /*
        public async Task<Car?> PostCarAsync(Car car)
        {
            await Context.Cars.AddAsync(car);
            await Context.SaveChangesAsync();
            return car;
        }
        */
        public async Task<Car?> PostCarAsync(Car car)
        {
            try
            {
                await Context.Cars.AddAsync(car);
                using (var transaction = Context.Database.BeginTransaction())
                {
                    await Context.SaveChangesAsync();
                    transaction.Commit();
                }
                return car;
            }
            catch (Exception ex)
            {
                // Log the exception for debugging
                Console.WriteLine($"Error saving car: {ex.Message}");
                return null; // Or handle the error differently
            }
        }
    }
}
