using Microsoft.AspNetCore.Mvc;

namespace ESFE.RestauranteBD.web.UI.Controllers
{
    public class PlatillosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}