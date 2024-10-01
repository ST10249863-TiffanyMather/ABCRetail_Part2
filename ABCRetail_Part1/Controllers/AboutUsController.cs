using Microsoft.AspNetCore.Mvc;

namespace ABCRetail_Part1.Controllers
{
    public class AboutUsController : Controller
    {
        //display the about us view
        public IActionResult Index()
        {
            return View();
        }
    }
}

