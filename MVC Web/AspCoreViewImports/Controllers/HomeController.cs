using AspCoreViewImports.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspCoreViewImports.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            List<Student> students = new List<Student>
        {
            new Student{ Id = 1, Name = "Ankit", Gender = "Male"},
            new Student{ Id = 2, Name = "Kumar", Gender = "Male"},
            new Student{ Id = 3, Name = "Natasha", Gender = "FeMale"},
        };

            return View(students);
        }
        public IActionResult About()
        {
            List<Student> students = new List<Student>
        {
            new Student{ Id = 1, Name = "Ankit", Gender = "Male"},
            new Student{ Id = 2, Name = "Kumar", Gender = "Male"},
            new Student{ Id = 3, Name = "Natasha", Gender = "FeMale"},
        };
            return View(students);
        }
        public IActionResult Contect()
        {
            List<Student> students = new List<Student>
        {
            new Student{ Id = 1, Name = "Ankit", Gender = "Male"},
            new Student{ Id = 2, Name = "Kumar", Gender = "Male"},
            new Student{ Id = 3, Name = "Natasha", Gender = "FeMale"},
        };
            return View(students);
        }
    }
}
