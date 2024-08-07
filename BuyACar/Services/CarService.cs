using BuyACar.Models;
using BuyACar.Models.Car;
using BuyACar.Repositories;

namespace BuyACar.Services
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;
        private readonly ICarModelService _carModelService;
        
        public CarService(ICarRepository carRepository, ICarModelService carModelService)
        {
            _carRepository = carRepository;
            _carModelService = carModelService;
        }


        public async Task<CarRecord?> GetCarByIdAsync(int id)
        {
            return await _carRepository.GetCarByIdAsync(id);
        }

        public async Task<CarRecord?> GetCarByNameAsync (string name)
        {
            return await _carRepository.GetCarByNameAsync(name);
        }

        public async Task<CarRecord?> PostCarAsync(Car car)
        {

            CarModel? carModel = await _carModelService.GetCarModelByNameAsync(car.CarModel.Name);
            if (carModel == null)
            {
                return null;
            }


            var newCar = new Car
            {
                Name = car.Name,
                CarModel = carModel
            };
            Console.WriteLine(car);

            var createdCar = await _carRepository.PostCarAsync(car);

            return createdCar;
        }
    }
}
