using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BooksAppMVC.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [DisplayName("Order")]
        [Range(1,100,ErrorMessage="Display order must be between 1 and 100 only")]
        public int DisplayOrder { get; set; }
        [DisplayName("Created Date")]
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;//default value
    }
}
