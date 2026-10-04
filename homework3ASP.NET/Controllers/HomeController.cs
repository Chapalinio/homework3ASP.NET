using System.Diagnostics;
using homework3ASP.NET.Models;
using Microsoft.AspNetCore.Mvc;

namespace homework3ASP.NET.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
    }
}
