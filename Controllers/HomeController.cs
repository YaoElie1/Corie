using Microsoft.AspNetCore.Mvc;

namespace Corie.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Menu()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}