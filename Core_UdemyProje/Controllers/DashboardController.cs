using Microsoft.AspNetCore.Mvc;

namespace Core_UdemyProje.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.v1 = "Dashboard"; 
            ViewBag.v1 = "İstatislikler"; 
            ViewBag.v1 = "İstatistik Sayfası";
            return View();
        }
    }
}
