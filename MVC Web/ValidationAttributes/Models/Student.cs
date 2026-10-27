using System.ComponentModel.DataAnnotations;

namespace ValidationAttributes.Models
{
       public class Student
    {
        [Display(Name = "Student Name")]
        [Required(ErrorMessage = "Name Is Must")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 15 characters")]
        public string Name { get; set; } = null!;
        [Required(ErrorMessage = "Email Is Must")]
        //[EmailAddress]
        [RegularExpression(@"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$", ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; } = null!;
        [Required(ErrorMessage = "Age Is Must")]
        [Range(10, 50, ErrorMessage = "Age must be between 10 and 50")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Password Is Must")]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]{8,}$", ErrorMessage = "Password must contain at least one uppercase letter, one lowercase letter, one digit, and one special character")]
        public string Password { get; set; } = null!;
        //[Required(ErrorMessage = "Number Is Must")]
        //[RegularExpression(@"^[6-9]\d{9}$", ErrorMessage = "Please enter a valid 10-digit Indian mobile number")]
        //public string PNumber { get; set; } = null!;

    }
}