using DDLASPCore6.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;

namespace DDLASPCore6.Controllers
{

    public enum Gender
    {
        Male = 0,
        Female= 1,
    }
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<SelectListItem> Gender = new ()
            {
                new SelectListItem {Value ="Male", Text = "Male"},
                new SelectListItem {Value ="Female", Text = "Female"},
            };

            ViewBag.Gender
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
