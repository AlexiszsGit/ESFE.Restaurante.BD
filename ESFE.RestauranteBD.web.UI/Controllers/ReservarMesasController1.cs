using Microsoft.AspNetCore.Mvc;

namespace ESFE.Restaurante.BD.Controllers
{
    public class ReservarMesas1Controller : Controller
    {
        // GET: /ReservarMesas/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GuardarReserva(string nombre, int personas, string fecha, string hora)
        {
            return RedirectToAction("Index", "MenuDigital");
        }
    }
}