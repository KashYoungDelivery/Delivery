using Microsoft.AspNetCore.Mvc;

namespace Delivery.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class AdminController : Controller
    {
        [HttpGet]
        public IActionResult GetAllData() 
        {
            return View();
        }
    }
}
