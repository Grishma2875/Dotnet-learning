using System.ComponentModel.DataAnnotations;

namespace SyncSyntex.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "The Category Name is Required")]
        [MaxLength(100, ErrorMessage = "The Category name cannot exceed 100 characters")]
        public string Name { get; set; }
        public string? Description { get; set; } = string.Empty;
        public ICollection<Post> Posts { get; set; } 
    }
}
    