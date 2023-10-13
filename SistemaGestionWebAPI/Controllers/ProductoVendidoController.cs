using Microsoft.AspNetCore.Mvc;

namespace SistemaGestionWebAPI.Controllers
{
    public class ProductoVendidoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
