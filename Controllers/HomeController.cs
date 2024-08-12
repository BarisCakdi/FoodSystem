using FoodSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FoodSystem.Controllers
{
    public class HomeController : Controller
    {
      

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Menu()
        {
            return View();
        }
       public IActionResult About()
        {
            return View();
        }

     
    }
}
