namespace BuyACar.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public Car(string _name)
        {
            Name = _name;
        }
    }
}
