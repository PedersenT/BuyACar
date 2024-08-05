using BuyACar.Models;
using BuyACar.Repositories;

namespace BuyACar.Services
{
    public class CarModelService : ICarModelService
    {
        private readonly ICarModelRepository _carModelRepository;

        public CarModelService(ICarModelRepository carModelRepository)
        {
            _carModelRepository = carModelRepository;
        }

        public async Task<CarModel?> GetCarModelByNameAsync(string Name)
        {
            var CarModel = _carModelRepository.GetCarModelByNameAsync(Name);
            if (CarModel == null)
            {
                return null;
            }
            return await CarModel;
        }
    }
}
