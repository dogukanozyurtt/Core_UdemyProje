using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_UdemyProje.ViewComponents.Portfolio
{
    public class SlideList : ViewComponent
    {
        PortfolioMananager portfolioMananager = new PortfolioMananager(new EfPortfolioDal());

        public IViewComponentResult Invoke()
        {
            var values = portfolioMananager.TGetList();
            return View(values);
        }
    }
}
