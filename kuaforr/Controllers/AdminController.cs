using Microsoft.AspNetCore.Mvc;

namespace kuaforr.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult AdminPanel()
        {
            var yetki = HttpContext.Session.GetString("Yetki");
            if (yetki == "Admin")
            {
                return View();
            }
            else
            {
                return RedirectToAction("Giris", "Giris");
            }
        }
    }
} 


