﻿using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
