using System.Diagnostics;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TheWindCorner.Data.Models.User;
using TheWindCorner.Web.ViewModels;


namespace TheWindCorner.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly UserManager<ApplicationUser> _userManager;

        public HomeController(
            ILogger<HomeController> logger,
            UserManager<ApplicationUser> userManager
            )
        {
            _logger = logger;
            _userManager = userManager;
        }

        

        public IActionResult Index()
        {
            ViewData["Title"] = "Home Page";
            ViewData["Message"] = "Welcome to the TheWindCorner App";

            return View();
        }

        
    }
}
 