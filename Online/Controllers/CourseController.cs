﻿using Microsoft.AspNetCore.Mvc;

namespace Online.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
