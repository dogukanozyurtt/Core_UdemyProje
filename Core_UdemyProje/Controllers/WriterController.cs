using Microsoft.AspNetCore.Mvc;

namespace Core_UdemyProje.Controllers
{
    public class WriterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
