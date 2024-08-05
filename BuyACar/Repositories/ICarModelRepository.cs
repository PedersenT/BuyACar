using BuyACar.Models;

namespace BuyACar.Repositories
{
    public interface ICarModelRepository
    {
        Task<CarModel?> GetCarModelByNameAsync(string Name);
    }
}
