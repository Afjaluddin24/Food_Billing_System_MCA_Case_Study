using Food_Bill_Sustem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Food_Bill_Sustem.Controllers
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

        [Route("/Login")]
        public IActionResult Login()
        {
            return View();
        }
       

        
    }
}
