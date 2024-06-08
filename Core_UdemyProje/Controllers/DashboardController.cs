using Microsoft.AspNetCore.Mvc;

namespace Core_UdemyProje.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
