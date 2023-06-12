using DemoDockerWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DemoDockerWeb.Controllers
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
            string text = @"
  _    _       _         _____  _       _                  _   _            
 | |  | |     | |       |  __ \(_)     (_)                | | | |           
 | |__| | ___ | | __ _  | |__) |_  ___  _  __ _ _ __   ___| |_| |_ ___  ___ 
 |  __  |/ _ \| |/ _` | |  _  /| |/ _ \| |/ _` | '_ \ / _ \ __| __/ _ \/ __|
 | |  | | (_) | | (_| | | | \ \| | (_) | | (_| | | | |  __/ |_| ||  __/\__ \
 |_|  |_|\___/|_|\__,_| |_|  \_\_|\___/| |\__,_|_| |_|\___|\__|\__\___||___/
                                      _/ |                                  
                                     |__/                                   
";

            return Content(text, "text/plain");
        }

    }
}