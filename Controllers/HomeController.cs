﻿using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
