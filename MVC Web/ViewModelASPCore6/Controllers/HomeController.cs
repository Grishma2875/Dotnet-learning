using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ViewModelASPCore6.Models;

namespace ViewModelASPCore6.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Student> students = new List<Student>
            {
                new Student { Id = 1, Name = "Ali", Gender = "Male", Standard = 12},
                new Student { Id = 2, Name = "Krish", Gender = "Male", Standard = 10},
                new Student { Id = 3, Name = "Grishma", Gender = "Female", Standard = 11},
            };

            List<Teacher> teachers = new List<Teacher>
            {
                new Teacher { Id = 1, Name = "Sir Ali",  Qualification = "MCS", Salary  = 50000},
                new Teacher { Id = 2, Name = "Sir Krish",  Qualification = "BSIT", Salary = 45000},
                new Teacher { Id = 3, Name = "Mem Grishma",  Qualification = "MBA", Salary = 70000},
            };

            SchoolViewModel svm = new SchoolViewModel()
            {
                myStudents = students,
                MyTeachers = teachers,
            };

            return View(svm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
