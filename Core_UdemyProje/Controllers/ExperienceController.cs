﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_UdemyProje.Controllers
{
    public class ExperienceController : Controller
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());
        public IActionResult Index()
        {
            ViewBag.v1 = "Deneyim Listesi";
            ViewBag.v2 = "Deneyimler";
            ViewBag.v3 = "Deneyim Listesi";
            var values = experienceManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddExperience()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddExperience(Experience experience) 
        {
            ViewBag.v1 = "Deneyim Ekleme";
            ViewBag.v2 = "Deneyimler";
            ViewBag.v3 = "Deneyim Ekleme";
            experienceManager.TAdd(experience);
            return RedirectToAction("Index");
            
        }

        public IActionResult DeleteExperience(int id)
        {
            var values = experienceManager.TGetByID(id);
            experienceManager.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditExperience(int id)
        {
            ViewBag.v1 = "Güncelleme";
            ViewBag.v2 = "Deneyeimler";
            ViewBag.v3 = "Deneyeim Güncelleme";
            var values = experienceManager.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult EditExperience(Experience experience)
        {
            experienceManager.TUpdate(experience);
            return RedirectToAction("Index");
        }


    }
}
