using Microsoft.AspNetCore.Mvc;

namespace Delivery.Backend.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
