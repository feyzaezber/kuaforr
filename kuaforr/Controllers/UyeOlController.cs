using Microsoft.AspNetCore.Mvc;
using kuaforr.Models;
using kuaforr.Data; // Veritabanı bağlamı için
using System.Threading.Tasks;
using System;

namespace kuaforr.Controllers
{
    public class UyeOlController : Controller
    {
        private readonly ApplicationDbContext _context; // Veritabanı bağlamı

        public UyeOlController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult UyeOl()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Uye(Uye model)
        {
            /* if (ModelState.IsValid)
             {
                 _context.Uyes.Add(model); // Veriyi veritabanına ekle
                 await _context.SaveChangesAsync(); // Kaydet
                 return RedirectToAction("UyeOlSuccess"); // Başarılı işlem sonrası yönlendirme
             }

             return View(model); // Hatalıysa formu tekrar göster */


            if (ModelState.IsValid) // Model doğrulaması başarılı mı?
            {
                try
                {
                    // Yeni üye kaydını veritabanına ekle
                    _context.Uyes.Add(model);
                    await _context.SaveChangesAsync();

                    // Başarı sayfasına yönlendir
                    return RedirectToAction("UyeOlSuccess");
                }
                catch (Exception ex)
                {
                    // Eğer veritabanı veya başka bir hata varsa
                    ModelState.AddModelError("", "Bir hata oluştu: " + ex.Message);
                }
            }

            // ModelState başarısızsa tekrar formu göster
            return View("UyeOl", model);
        }

        // Başarı sayfası
        public IActionResult UyeOlSuccess()
        {
            return View("~/Views/UyeOl/UyeOlSuccess.cshtml");
        }

        public IActionResult UyeBilgileri()
        {
            var uyeler = _context.Uyes.ToList(); // Veritabanındaki randevuları alır
            return View(uyeler); // View'e randevu listesini gönderir
        }
    }


}

