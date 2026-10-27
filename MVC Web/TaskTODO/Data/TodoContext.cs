using Microsoft.AspNetCore.Mvc;

namespace TaskTODO.Data
{
    public class TodoContext : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
