using BuyACar.Models;

namespace BuyACar.Services
{
    public class CarService : ICarService
    {
        public CarService() { }

        public Car? GetCar()
        {
            Car car = new Car("Skoda Enyaq");
            return car;
        }
    }
}
