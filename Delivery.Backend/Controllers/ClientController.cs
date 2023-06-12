using Microsoft.AspNetCore.Mvc;

namespace Delivery.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ClientController : Controller
    {
        [HttpGet]
        public IActionResult GetAllData() 
        {
            return Ok();
        }
    }
}
