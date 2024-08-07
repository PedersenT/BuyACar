using BuyACar.Data;
using BuyACar.Models.Car;
using Microsoft.EntityFrameworkCore;


namespace BuyACar.Repositories
{
    public interface ICarRepository
    {
        Task<CarRecord?> GetCarByIdAsync(int id);
        Task<CarRecord?> GetCarByNameAsync(string name);
        Task<CarRecord?> PostCarAsync(Car car);
    }
}
