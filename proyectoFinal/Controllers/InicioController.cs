using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace proyectoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InicioController : Controller {
        public IActionResult Index()
        {
            return View();
        }
    }
}
