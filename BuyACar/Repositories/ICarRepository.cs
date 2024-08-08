using BuyACar.Data;
using BuyACar.Models.Car;
using Microsoft.EntityFrameworkCore;


namespace BuyACar.Repositories
{
    public interface ICarRepository
    {
        Task<CarDto?> GetCarByFinnIdAsync(int finnId);
/*        Task<CarRecord?> GetCarByNameAsync(string name);
*/        Task<CarDto?> PostCarAsync(Car car);
    }
}
