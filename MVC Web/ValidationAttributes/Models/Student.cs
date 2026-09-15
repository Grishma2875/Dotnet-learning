using System.ComponentModel.DataAnnotations;

namespace ValidationAttributes.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Name Is Must")]
        [StringLength(15,MinimumLength = 3)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email Is Must")]
        public string Email { get; set; }
    }
}
