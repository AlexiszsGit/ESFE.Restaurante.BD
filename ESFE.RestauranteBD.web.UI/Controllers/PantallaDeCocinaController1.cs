using Microsoft.AspNetCore.Mvc;

namespace ESFE.Restaurante.BD.Controllers
{
    public class PantallaDeCocina1Controller : Controller
    {
        // GET: /PantallaDeCocina/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ActualizarEstadoOrden(int idOrden, string nuevoEstado)
        {
            return Json(new { success = true });
        }
    }
}