using Microsoft.AspNetCore.Mvc;

namespace ESFE.RestauranteBD.web.UI.Controllers
{
    public class GestionDePedidos1Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EnviarACocina(int idPedido)
        {
            return RedirectToAction("Index", "PantallaDeCocina");
        }
    }
}
