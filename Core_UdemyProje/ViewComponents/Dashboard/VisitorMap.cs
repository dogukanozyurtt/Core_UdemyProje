using Microsoft.AspNetCore.Mvc;

namespace Core_UdemyProje.ViewComponents.Dashboard
{
    public class VisitorMap:ViewComponent
    {

        public IViewComponentResult Invoke()
        {

            return View();
        }

    }
}
