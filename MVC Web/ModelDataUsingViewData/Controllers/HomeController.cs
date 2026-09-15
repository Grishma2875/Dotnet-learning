using Microsoft.AspNetCore.Mvc;
using ModelDataUsingViewData.Models;
using System.Diagnostics;

namespace ModelDataUsingViewData.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //Employee emp = new Employee()
            //{
            //       EmpId = 101,
            //       EmpName = "Ali",
            //       Designation = "Manager",
            //       Salary = 25000
            //};

            //ViewData["myEmployee"] = emp;
            //ViewBag.myEmployee = emp;

            var myEmployees = new List<Employee>
            {
                new Employee { EmpId = 101, EmpName = "Prem", Designation = "Manager", Salary = 25000},
                new Employee { EmpId = 102, EmpName = "Grishma", Designation = "Manager", Salary = 25000},
                new Employee { EmpId = 103, EmpName = "Jeeya", Designation = "Manager", Salary = 25000},
                new Employee { EmpId = 104, EmpName = "Yash", Designation = "Manager", Salary = 25000},
                new Employee { EmpId = 105, EmpName = "Rohan", Designation = "Manager", Salary = 25000},
            };

            ViewData["myEmployee"] = myEmployees;



            return View();
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
