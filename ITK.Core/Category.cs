using System.ComponentModel.DataAnnotations;

namespace ITK.Core
{
    public class Category
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(25, ErrorMessage = "Maximum 25 character limit")]

        public string Title { get; set; }
        [Required]
        [MinLength(4, ErrorMessage = "Category code must be 4 characters long")]
        // Must be unique, so add constraint with fluent api
        public string Code { get; set; }
    }
}