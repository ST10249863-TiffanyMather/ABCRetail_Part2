using ABCRetail_Part1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ABCRetail_Part1.Controllers
{
    public class HomeController : Controller
    {
        //logger to log information and errors
        private readonly ILogger<HomeController> _logger; 

        //constructor to inject ILogger service
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //display the home view
        public IActionResult Index()
        {
            return View();
        }

        //display the privacy view
        public IActionResult Privacy()
        {
            return View();
        }

        //error message
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)] 
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
