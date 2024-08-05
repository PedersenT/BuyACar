using System.ComponentModel.DataAnnotations;

namespace BuyACar.Models
{
    public class CarModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public Manufacturer Manufacturer { get; set; } = null!;

        public CarModel() { }

        public CarModel(string name, Manufacturer manufacturer)
        {
            Name = name;
            Manufacturer = manufacturer;
        }
    }
}
