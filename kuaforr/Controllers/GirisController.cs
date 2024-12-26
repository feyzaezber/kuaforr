using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Eventing.Reader;

namespace kuaforr.Controllers
{
    public class GirisController : Controller
    {

        public string publicUsername = "User";
        public string publicPassword = "Pass";
        public IActionResult Giris()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Giris(FormCollection fc) { 
            string username = fc["username"];
            string password = fc["password"];
            HttpContext.Session.SetString("Yetki", username);

            if (username == publicUsername && password == publicPassword) {
                //  HttpContext.Session.SetString("Yetki", username);
                // Session["Yetki"] = username;

                // Session'a değer atama
                HttpContext.Session.SetString("Yetki", username);

                // Session'dan değer alma
                string yetki = HttpContext.Session.GetString("Yetki");
                return Redirect("/Home/Index");
            }
            else
            {
                return View();
            }
            
        }
    }
}
