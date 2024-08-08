using BuyACar.Models.Car;

namespace BuyACar.Services
{
    public interface ICarService
    {
        Task<CarDto?> GetCarByFinnIdAsync(int finnId);
        Task<CarDto?> PostCarAsync(Car car);

    }
}
