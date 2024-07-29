using BuyACar.Data;
using BuyACar.Models;

namespace BuyACar.Repositories
{
    public class CarRepository : ICarRepository
    {

        private readonly BuyACarContext context;

        public CarRepository(BuyACarContext context)
        {
            this.context = context;
        }

        public Car? GetCarById(int id)
        {
            return context.Cars.Find(id);
        }
    }
}
