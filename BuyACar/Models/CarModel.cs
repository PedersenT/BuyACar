using System.ComponentModel.DataAnnotations;

namespace BuyACar.Models
{
    public class CarModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int StorageCapacity { get; set; } 
        public int TrailerWeight { get; set; }
        public Manufacturer Manufacturer { get; set; } = null!;

        public CarModel() { }

        public CarModel(int id, string name, int storageCapacity, int trailerWeight, Manufacturer manufacturer)
        {
            Id = id;
            Name = name;
            StorageCapacity = storageCapacity;
            TrailerWeight = trailerWeight;
            Manufacturer = manufacturer;
        }

    

        /*public CarModel(string name, Manufacturer manufacturer)
        {
            Name = name;
            Manufacturer = manufacturer;
        }*/
    }
}
