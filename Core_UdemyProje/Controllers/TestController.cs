﻿using Microsoft.AspNetCore.Mvc;

namespace Core_UdemyProje.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
