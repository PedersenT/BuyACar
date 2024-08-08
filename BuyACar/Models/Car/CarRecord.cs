namespace BuyACar.Models.Car
{
    public record CarRecord(int FinnId, string Url, string SellerType,
        int ProductionYear, string Color, int KilometersDriven, 
        string WheelDrive, string CarModelName, string ManufacturerName,
        int StorageCapacity, int TrailerWeight);
}
