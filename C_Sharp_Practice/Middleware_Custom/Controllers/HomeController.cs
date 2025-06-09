using Microsoft.AspNetCore.Mvc;

namespace Middleware_Custom.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
