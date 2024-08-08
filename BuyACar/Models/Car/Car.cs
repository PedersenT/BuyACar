using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BuyACar.Models.Car
{
    public class Car
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int FinnId { get; set; }
        public string Url { get; set; } = null!;
        public string SellerType { get; set; } = null!;
        public int ProductionYear { get; set; }
        public string Color { get; set; } = null!;
        public int KilometersDriven { get; set; }
        public string WheelDrive { get; set; } = null!;
        public CarModel CarModel { get; set; } = null!;

        public Car() { }
        public Car(int finnId, string url, string sellerType, int productionYear, string color, int kilometersDriven, string wheelDrive, CarModel carModel)
        {
            FinnId = finnId;
            Url = url;
            SellerType = sellerType;
            ProductionYear = productionYear;
            Color = color;
            KilometersDriven = kilometersDriven;
            WheelDrive = wheelDrive;
            CarModel = carModel;
        }

        public CarDto ToCarRecord()
        {
            return new CarDto(this.FinnId, this.Url, this.SellerType, this.ProductionYear, 
                this.Color, this.KilometersDriven, this.WheelDrive, this.CarModel.Name, 
                this.CarModel.Manufacturer.Name, this.CarModel.StorageCapacity, this.CarModel.TrailerWeight);
        }
    }
}
