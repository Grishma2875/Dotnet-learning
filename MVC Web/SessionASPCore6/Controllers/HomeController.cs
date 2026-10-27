using Microsoft.AspNetCore.Mvc;
using SessionASPCore6.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;

namespace SessionASPCore6.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.SetString("MyKey","Programentor");
            TempData["SesstionId"] = HttpContext.Session.Id;
            return View();
        }
        public IActionResult About()
        {
            if(HttpContext.Session.GetString("MyKey") != null)
            {
                ViewBag.Data = HttpContext.Session.GetString("MyKey").ToString();
            }
            return View();
        }

        public IActionResult Details()
        {
            if (HttpContext.Session.GetString("MyKey") != null)
            {
                ViewBag.Data = HttpContext.Session.GetString("MyKey").ToString();
            }
            return View();
        }
         public IActionResult Logout()
        {
            if (HttpContext.Session.GetString("MyKey") != null)
            {
                 HttpContext.Session.Remove("MyKey");
            }
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
