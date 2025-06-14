using System.Diagnostics;
using DIYBurgerMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DIYBurgerMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Customize()
        {
            return View();
        }

        public IActionResult Menu()
        {
            return View();
        }
    }
}
