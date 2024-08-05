using BuyACar.Models.Car;

namespace BuyACar.Services
{
    public interface ICarService
    {
        Task<Car?> GetCarByIdAsync(int id);
        Task<Car?> PostCarAsync(CarPostDTO carPostDTO);
    }
}
