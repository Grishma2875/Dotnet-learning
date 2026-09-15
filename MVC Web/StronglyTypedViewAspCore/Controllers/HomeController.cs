using Microsoft.AspNetCore.Mvc;
using StronglyTypedViewAspCore.Models;
using System.Diagnostics;

namespace StronglyTypedViewAspCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //Employee obj = new Employee()
            //{
            //    EmpId = 101,
            //    EmpName = "Grishma",
            //    Designation = "manager",
            //    Salary = 20000,
            //};

            var myEmployees = new List<Employee>
            {
                new Employee { EmpId = 101, EmpName = "Grishma", Designation = "Mnager", Salary = 20000 }
                new Employee { EmpId = 102, EmpName = "Hetvi", Designation = "Mnager", Salary = 20000 }
                new Employee { EmpId = 103, EmpName = "Krish", Designation = "Mnager", Salary = 20000 }
                new Employee { EmpId = 104, EmpName = "Ansh", Designation = "Mnager", Salary = 20000 }
                new Employee { EmpId = 105, EmpName = "Princy", Designation = "Mnager", Salary = 20000 }

            };
            return View(myEmployees);
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
