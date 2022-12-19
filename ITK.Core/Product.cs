using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITK.Core
{
    public class Product
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(25, ErrorMessage = "Maximum 25 character limit")]
        public string  Title { get; set; }
        [Required]
        [MaxLength(150, ErrorMessage = "Maximum 150 character limit")]
        public string  Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int? StockQuantity { get; set; }
        [Required]
        [MaxLength(25, ErrorMessage = "Maximum 25 character limit")]
        public string Image { get; set; }
        [Required]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        [MaxLength(25, ErrorMessage = "Maximum 300 character limit")]
        public string EditorsNote { get; set; } = string.Empty;
    }
}
