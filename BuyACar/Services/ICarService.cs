using BuyACar.Models.Car;

namespace BuyACar.Services
{
    public interface ICarService
    {
        Task<CarRecord?> GetCarByIdAsync(int id);
        Task<CarRecord?> GetCarByNameAsync(string name);
        Task<CarRecord?> PostCarAsync(Car car);

    }
}
