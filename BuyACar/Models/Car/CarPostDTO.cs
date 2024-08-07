namespace BuyACar.Models.Car
{
    public record CarPostDTO
    {
        public string Name { get; set; } = null!;
        public string CarModelName { get; set; } = null!;
        public string ManufacturerName { get; set; } = null!;
    }
}
