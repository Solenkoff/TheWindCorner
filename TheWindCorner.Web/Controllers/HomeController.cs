using System.Diagnostics;

using Microsoft.AspNetCore.Mvc;

using TheWindCorner.Web.ViewModels;


namespace TheWindCorner.Web.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public HomeController()
        {

        }

        public IActionResult Index()
        {
            ViewData["Title"] = "Home Page";
            ViewData["Message"] = "Welcome to the TheWindCorner App";

            return View();
        }

        
    }
}
 