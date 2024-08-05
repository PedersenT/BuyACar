using BuyACar.Data;
using BuyACar.Models.Car;
using Microsoft.EntityFrameworkCore;


namespace BuyACar.Repositories
{
    public interface ICarRepository
    {
        Task<Car?> GetCarByIdAsync(int id);

        Task<Car?> PostCarAsync(Car car);
    }
}
