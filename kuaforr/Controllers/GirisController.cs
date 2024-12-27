/* using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Eventing.Reader;
using Microsoft.AspNetCore.Http;

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
                Session["Yetki"] = username;

                // Session'a değer atama
              /*  HttpContext.Session.SetString("Yetki", username);

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
} */








/* using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http; // Session için gerekli

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
        public IActionResult Giris(string username, string password)
        {
            // Kullanıcı adını Session'a kaydet
            if (username == publicUsername && password == publicPassword)
            {
                HttpContext.Session.SetString("Yetki", username);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.ErrorMessage = "Kullanıcı adı veya şifre hatalı!";
                return View();
            }
        }
    }
} */






using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace kuaforr.Controllers
{
    public class GirisController : Controller
    {
        // Kullanıcı listesi (örnek olarak statik bir liste kullanılıyor)
        private readonly List<(string Username, string Password, string Role)> users = new()
        {
            ("User1", "Pass1", "User"), // Normal kullanıcı
            ("User2", "Pass2", "User"), // Normal kullanıcı
            ("Admin", "AdminPass", "Admin") // Admin kullanıcı
        };

        public IActionResult Giris()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Giris(string username, string password)
        {
            // Kullanıcıyı kontrol et
            var user = users.FirstOrDefault(u => u.Username == username && u.Password == password);

            if (user != default)
            {
                // Kullanıcı bulundu, rolüne göre işlem yap
                HttpContext.Session.SetString("Yetki", user.Role);
                HttpContext.Session.SetString("Username", user.Username);

                if (user.Role == "Admin")
                {
                    return RedirectToAction("AdminPanel", "Admin");
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                ViewBag.ErrorMessage = "Kullanıcı adı veya şifre hatalı!";
                return View();
            }
        }
    }
}


