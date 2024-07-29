using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BuyACar.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }

        public Car()
        {
        }

        public Car(string name)
        {
            Name = name;
        }
    }
}
