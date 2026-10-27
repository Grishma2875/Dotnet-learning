using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace TodoApp.Models
{
    public class Todo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Task name is required")]
        public string TaskName { get; set; } = null!;

        [Required(ErrorMessage = "User name is required")]
        public string UserName { get; set; } = null!;


        public string? Description { get; set; } = string.Empty;

        public bool IsDeleted { get; set; } = false;
    }
}
        