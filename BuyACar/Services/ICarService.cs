using BuyACar.Models.Car;

namespace BuyACar.Services
{
    public interface ICarService
    {
        Task<CarRecord?> GetCarByFinnIdAsync(int finnId);
*/        Task<CarRecord?> PostCarAsync(Car car);

    }
}
