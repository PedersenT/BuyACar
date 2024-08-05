using System.ComponentModel.DataAnnotations;

namespace BuyACar.Models.Car
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public CarModel CarModel { get; set; } = null!;

        public Car() { }

        public Car(string name, CarModel carModel)
        {
            Name = name;
            CarModel = carModel;
        }
    }
}
