using Microsoft.AspNetCore.Mvc;

namespace SistemaGestionWebAPI.Controllers
{
    public class VentaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
