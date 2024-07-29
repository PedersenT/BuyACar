using BuyACar.Models;

namespace BuyACar.Services
{
    public interface ICarService
    {
        public Car? GetCarById(int id);
    }
}
