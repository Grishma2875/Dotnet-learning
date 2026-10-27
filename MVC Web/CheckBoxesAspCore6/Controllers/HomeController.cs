using CheckBoxesASPCore6.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CheckBoxesASPCore6.Controllers
{
    public class HomeController : Controller
    {
        //public IActionResult Index()
        //{
        //    var model = new ViewModel()
        //    {
        //        AcceptTerms = false,
        //        Text = "I Accept The Terms",
        //    };
        //    return View(model);
        //}
        public IActionResult Index()
        {
            var model = new ViewModel()
            {
                CheackBoxes = new List<CheckBoxOption>
                {
                     new CheckBoxOption()
                     {
                        IsChecked = true,
                        Text = "Cricket",
                        Value = "Cricket",
                     },
                     new CheckBoxOption()
                     {
                        IsChecked = true,
                        Text = "Football",
                        Value = "Football",
                     },
                     new CheckBoxOption()
                     {
                        IsChecked = true,
                        Text = "Hockey",
                        Value = "Hockey",
                     },

                }

            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(ViewModel data)
        {
            //var value = data.AcceptTerms;
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
