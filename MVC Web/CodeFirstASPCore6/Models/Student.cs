using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstASPCore6.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Column("StudentName", TypeName = "varchar(100)")]
        public string Name { get; set; } = null!;

        [Column("StudentName", TypeName = "varchar(100)")]
        public string Gender { get; set; } = null!;
        public int Age { get; set; }
    }
}
