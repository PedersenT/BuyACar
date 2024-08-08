using BuyACar.Data;
using BuyACar.Models.Car;
using Microsoft.EntityFrameworkCore;


namespace BuyACar.Repositories
{
    public interface ICarRepository
    {
        Task<CarRecord?> GetCarByFinnIdAsync(int finnId);
/*        Task<CarRecord?> GetCarByNameAsync(string name);
*/        Task<CarRecord?> PostCarAsync(Car car);
    }
}
