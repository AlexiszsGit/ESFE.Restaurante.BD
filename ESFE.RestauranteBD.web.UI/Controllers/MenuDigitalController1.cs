using Microsoft.AspNetCore.Mvc;

namespace ESFE.RestauranteBD.web.UI.Controllers
{
    public class MenuDigital1Controller : Controller
    {
        public IActionResult Index(string buscar, string categoria)
        {
            return View();
        }
    }
}

