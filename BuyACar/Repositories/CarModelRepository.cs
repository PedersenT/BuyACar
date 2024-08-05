using BuyACar.Data;
using BuyACar.Models;
using Microsoft.EntityFrameworkCore;


namespace BuyACar.Repositories
{
    public class CarModelRepository : ICarModelRepository
    {
        private readonly BuyACarContext _context;

        public CarModelRepository(BuyACarContext context)
        {
            _context = context;
        }

        public async Task<CarModel?> GetCarModelByNameAsync(string Name)
        {
            try
            {

                
                
                return await _context.CarModels
                .FirstOrDefaultAsync(x => x.Name == Name);

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
