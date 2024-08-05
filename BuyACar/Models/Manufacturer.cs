using System.ComponentModel.DataAnnotations;

namespace BuyACar.Models
{
    public class Manufacturer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public Manufacturer() { }

        public Manufacturer(string name) 
        { 
            Name = name; 
        }
    }
}
