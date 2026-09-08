using Microsoft.AspNetCore.Mvc;

namespace ESFE.Restaurante.BD.Controllers
{
    public class PedidoyCarrito1Controller : Controller
    {
        // GET: /PedidoyCarrito/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AgregarProducto(int idProducto, int cantidad)
        {
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult EliminarProducto(int idProducto)
        {
            return RedirectToAction(nameof(Index));
        }
    }
}