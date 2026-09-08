using Microsoft.AspNetCore.Mvc;

namespace ESFE.Restaurante.BD.Controllers
{
    public class Pago1Controller : Controller
    {
        // GET: /Pago/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ProcesarPago(string metodoPago)
        {
            return RedirectToAction("Index", "PedidoListoController1");
        }
    }
}