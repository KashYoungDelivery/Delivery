using Microsoft.AspNetCore.Mvc;

namespace Delivery.Backend.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
