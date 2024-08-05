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


        public async Task<Car?> GetCarByIdAsync(int id)
        {
            return await _carRepository.GetCarByIdAsync(id);
        }

        public async Task<Car?> PostCarAsync(CarPostDTO carPostDTO)
        {

            //hente carmodel helt ferdig, så gå videre.
            
            /*
            var carModel = await _carModelService.GetCarModelByNameAsync(carPostDTO.CarModelName);
            if (carModel == null)
            {
                return null;
            }
            */
            if (carPostDTO == null)
            {
                return null;
            }

            var car = new Car
            {
                Name = carPostDTO.Name,
                CarModel = carModel.
            };

            var createdCar = _carRepository.PostCarAsync(car);
            if (createdCar == null)
            {
                return null;
            }

            return await _carRepository.PostCarAsync(car);
        }
    }
}
