﻿using Microsoft.AspNetCore.Mvc;

namespace views_practice.Areas.User.Controllers
{



    public class Error : Controller
    {


        public IActionResult notFound()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
