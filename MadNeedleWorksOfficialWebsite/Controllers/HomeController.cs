﻿using MadNeedleWorksOfficialWebsite.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MadNeedleWorksOfficialWebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Portfolio()
        {
            return View();
        }

        public IActionResult Products()
        {
            return View();
        }

        public IActionResult Patterns()
        {
            return View();
        }

        public IActionResult CustomRequests()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}