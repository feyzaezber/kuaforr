using System.Diagnostics;
using kuaforr.Models;
using Microsoft.AspNetCore.Mvc;

namespace kuaforr.Controllers
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
            var yetki = HttpContext.Session.GetString("Yetki");
            if (yetki == "User" || yetki == "Admin")
            {
                return View();
            }
            else
            {
                return RedirectToAction("Giris", "Giris");
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
