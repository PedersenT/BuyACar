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
            return await _context.CarModels
                .AsNoTracking()
                .Where(x => x.Name.Equals(Name))
                .FirstOrDefaultAsync();

        }

    }







}

