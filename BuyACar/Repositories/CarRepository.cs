using BuyACar.Data;
using BuyACar.Models.Car;
using Microsoft.EntityFrameworkCore;

namespace BuyACar.Repositories
{
    public class CarRepository : ICarRepository
    {

        private readonly BuyACarContext Context;

        public CarRepository(BuyACarContext context)
        {
            this.Context = context;
        }

        public async Task<CarDto?> GetCarByFinnIdAsync(int finnId)
        {
            return await Context.Cars
                .Where(c => c.FinnId == finnId)
                .Select(c => new CarDto(
                    c.FinnId, 
                    c.Url,
                    c.SellerType,
                    c.ProductionYear,
                    c.Color,
                    c.KilometersDriven,
                    c.WheelDrive,
                    c.CarModel.Name,
                    c.CarModel.Manufacturer.Name,
                    c.CarModel.StorageCapacity,
                    c.CarModel.TrailerWeight
                ))
                .FirstOrDefaultAsync();
        }


        public async Task<CarDto?> PostCarAsync(Car car)
        {
            var carModel = Context.CarModels.FirstOrDefault(c => c.Name == car.CarModel.Name);
            if (carModel == null)
            {
                throw new ArgumentException("Invlaid Car Model");
            }

            car.CarModel = carModel;

            Context.Cars.Add(car);
            await Context.SaveChangesAsync();

            var savedCar = Context.Cars.Include(c => c.CarModel).ThenInclude(cm => cm.Manufacturer).FirstOrDefault(c => c.Id == car.Id);
            if (savedCar == null)
            {
                throw new InvalidOperationException($"Expected a car with Id {car.Id}, but none was found.");
            }

            return savedCar.ToCarRecord();

        }
    }
}
