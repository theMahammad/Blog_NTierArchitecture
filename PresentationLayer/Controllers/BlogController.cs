﻿using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    public class BlogController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
