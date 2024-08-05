using BuyACar.Models;

namespace BuyACar.Services
{
    public interface ICarModelService
    {
        Task<CarModel?> GetCarModelByNameAsync(string Name);
    }
}
