using Microsoft.AspNetCore.Mvc;

namespace task.Properties.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
