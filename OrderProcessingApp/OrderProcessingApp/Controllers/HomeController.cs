﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrderProcessingApp.Models;

namespace OrderProcessingApp.Controllers
{
    public class HomeController : Controller
    {
        // Simple home page for view order screen
        public IActionResult Index()
        {
            return View();
        }
    }
}
