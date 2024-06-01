using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace Core_UdemyProje.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioMananager portfolioMananager = new PortfolioMananager(new EfPortfolioDal());

        //Portfoli Index
        public IActionResult Index()
        {
            ViewBag.v1 = "Proje Listesi";
            ViewBag.v2 = "Projelerim";
            ViewBag.v3 = "Proje Listesi";
            var values = portfolioMananager.TGetList();
            return View(values);
        }

        //Portfoli add Get
        [HttpGet]
        public IActionResult AddPortfolio()
        {
            ViewBag.v1 = "Proje Listesi";
            ViewBag.v2 = "Projelerim";
            ViewBag.v3 = "Proje Ekleme";
            return View();
        }


        //Portfoli add Post
        [HttpPost]
        public IActionResult AddPortfolio(Portfolio p)
        {


            PortfolioValidator validations = new PortfolioValidator();
            ValidationResult result = validations.Validate(p);
            if (result.IsValid)
            {
                portfolioMananager.TAdd(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();
        }


        // Portfolio Delete 
        public IActionResult DeletePortfolio(int id)
        {
            var values = portfolioMananager.TGetByID(id);
            portfolioMananager.TDelete(values);
            return RedirectToAction("Index");
        }



        // Portfolio Edit 
        [HttpGet]
        public IActionResult EditPortfolio(int id)
        {
            ViewBag.v1 = "Düzenleme";
            ViewBag.v2 = "Projeler";
            ViewBag.v3 = "Proje Düzenleme";
            var values = portfolioMananager.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult EditPortfolio(Portfolio portfolio)
        {

            PortfolioValidator validations = new PortfolioValidator();
            ValidationResult result = validations.Validate(portfolio);
            if (result.IsValid)
            {
                portfolioMananager.TUpdate(portfolio);
                return RedirectToAction("Index");
            }

            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();

        }


    }
}
