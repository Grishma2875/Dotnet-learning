using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ValidationAttributes.Models;

namespace ValidationAttributes.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Student std)
        {
            if (ModelState.IsValid)
            {
                return Content("Name is: " + std.Name +
                               "\nMobile Number is: ");
            }
            else
            {
                return Content("Validation Failed..");
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            });
        }
    }
}