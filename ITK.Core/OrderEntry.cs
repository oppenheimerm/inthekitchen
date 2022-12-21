using System.ComponentModel.DataAnnotations;

namespace ITK.Core
{
    public class OrderEntry
    {
        public int Id { get; set; }
        [Required]
        public int ProductId { get; set; }
        public Product? Product { get; set; }
        [Required]
        public int Quantity { get; set; }
        public double Price { get; protected set; }
        public void GetPrice() {
            Price = Quantity * Price;
        }
    }
}