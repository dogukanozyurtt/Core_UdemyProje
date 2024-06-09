using Microsoft.AspNetCore.Mvc;

namespace Core_UdemyProje.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.v1 = "Dashboard"; 
            ViewBag.v2 = "İstatislikler"; 
            ViewBag.v3 = "İstatistik Sayfası";
            return View();
        }
    }
}
