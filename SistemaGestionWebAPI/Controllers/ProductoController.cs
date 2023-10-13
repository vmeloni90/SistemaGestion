using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic; 
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestionWebAPI.Controllers
{
    public class ProductoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
