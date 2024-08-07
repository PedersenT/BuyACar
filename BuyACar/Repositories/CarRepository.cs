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

        public async Task<CarRecord?> GetCarByIdAsync(int id)
        {
            return await Context.Cars
                .Where(c => c.Id == id)
                .Select(c => new CarRecord(
                    c.Name,
                    c.CarModel.Name,
                    c.CarModel.Manufacturer.Name
                ))
                .FirstOrDefaultAsync();
        }
        public async Task<CarRecord?> GetCarByNameAsync(string name)
        {
            return await Context.Cars
                .Where (c => c.Name == name)
                .Select(c => new CarRecord(
                    c.Name,
                    c.CarModel.Name,
                    c.CarModel.Manufacturer.Name
                ))
                .FirstOrDefaultAsync();
        }


        public async Task<CarRecord?> PostCarAsync(Car car)
        {
            var carModel = Context.CarModels.FirstOrDefault(c => c.Name == car.CarModel.Name);
            //var carModel = Context.CarModels.Find(1);
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
