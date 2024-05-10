using Microsoft.AspNetCore.Mvc;

namespace Core_UdemyProje.Controllers
{
    public class FeatureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
