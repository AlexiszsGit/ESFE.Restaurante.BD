using Microsoft.AspNetCore.Mvc;

namespace ESFE.RestauranteBD.web.UI.Controllers
{
    public class IniciarSesion1Controller : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password))
            {
                return RedirectToAction("Index", "MenuDigital");
            }
            ViewBag.Error = "Credenciales incorrectas.";
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(string nombre, string email, string password)
        {
            return RedirectToAction("Login");
        }
    }
}
