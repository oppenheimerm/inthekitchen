using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [MaxLength(160, ErrorMessage = "Maximum 160 character limit")]
        public string  Title { get; set; }
        [Required]
        [MaxLength(200, ErrorMessage = "Maximum 200 character limit")]
        public string  Description { get; set; }
        [Required]
        [Column(TypeName = "money")]
        public decimal Price { get; set; }
        [Required]
        public int? StockQuantity { get; set; }
        [Required]
        [MaxLength(256, ErrorMessage = "Maximum 256 character limit")]
        public string Image { get; set; }
        [Required]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        [MaxLength(25, ErrorMessage = "Maximum 300 character limit")]
        public string EditorsNote { get; set; } = string.Empty;
    }
}
