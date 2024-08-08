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


        public async Task<CarDto?> GetCarByFinnIdAsync(int finnId)
        {
            return await _carRepository.GetCarByFinnIdAsync(finnId);
        }

        public async Task<CarDto?> PostCarAsync(Car car)
        {

            /*CarModel? carModel = await _carModelService.GetCarModelByNameAsync(car.CarModel.Name);
            if (carModel == null)
            {
                return null;
            }


            var newCar = new Car
            {
                FinnId = car.Name,
                CarModel = carModel
            };*/
            /*
            var newCar = new Car
            {
                FinnId = car.FinnId,
                Url = car.Url,
                SellerType = car.SellerType,
                ProductionYear = car.ProductionYear,
                Color = car.Color,
                KilometersDriven = car.KilometersDriven,
                WheelDrive = car.WheelDrive,
                CarModel 
            };*/

            var createdCar = await _carRepository.PostCarAsync(car);

            return createdCar;
        }
    }
}
