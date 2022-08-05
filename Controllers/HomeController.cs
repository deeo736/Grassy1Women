using GrassyWomen.Models;

using Microsoft.AspNetCore.Mvc;


namespace GrassyWomen.Controllers
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
        public IActionResult Mission()
        {
            return View();
        }
        public IActionResult Client()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Product()
        {
            return View();
        }
        public IActionResult Blog()
        {
            return View();
        }
        public IActionResult Faq()
        {
            return View();
        }
        public IActionResult Gallery()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

        public IActionResult Privacy()
        {
            return View();

        }

    }
}