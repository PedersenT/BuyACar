using BuyACar.Models;
using BuyACar.Repositories;

namespace BuyACar.Services
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;
        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }


        public Car? GetCarById(int id)
        {
            return _carRepository.GetCarById(id);

        }
    }
}
