using Microsoft.AspNetCore.Mvc;

namespace ESFE.RestauranteBD.web.UI.Controllers
{
    public class GestionDeMenu1Controller : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/GestionDeMenu1/Index.cshtml");
        }
    }
}
