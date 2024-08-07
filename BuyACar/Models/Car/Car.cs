using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BuyACar.Models.Car
{
    public class Car
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public CarModel CarModel { get; set; } = null!;

        public Car() { }

        public Car(string name, CarModel carModel)
        {
            Name = name;
            CarModel = carModel;
        }

        public CarRecord ToCarRecord()
        {
            return new CarRecord(this.Name, this.CarModel.Name, this.CarModel.Manufacturer.Name);
        }
    }
}
