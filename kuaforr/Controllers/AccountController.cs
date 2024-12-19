using Microsoft.AspNetCore.Mvc;

namespace kuaforr.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
