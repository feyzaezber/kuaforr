/* using Microsoft.AspNetCore.Mvc;

namespace kuaforr.Controllers
{
    public class RandevuController : Controller
    {
        public IActionResult Randevu()
        {
            return View();
        }
    }
} */

using Microsoft.AspNetCore.Mvc;
using kuaforr.Models;
using kuaforr.Data; // Veritabanı bağlamı için
using System.Threading.Tasks;
using System;

namespace kuaforr.Controllers
{
    public class RandevuController : Controller
    {
        private readonly ApplicationDbContext _context; // Veritabanı bağlamı

        public RandevuController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Randevu()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Randevu(Randevu model)
        {
            if (ModelState.IsValid)
            {
                _context.Randevus.Add(model); // Veriyi veritabanına ekle
                await _context.SaveChangesAsync(); // Kaydet
                return RedirectToAction("RandevuSuccess"); // Başarılı işlem sonrası yönlendirme
            }

            return View(model); // Hatalıysa formu tekrar göster
        }

        // Başarı sayfası
        public IActionResult RandevuSuccess()
        {
            return View("~/Views/Randevu/RandevuSuccess.cshtml");
        }

        public IActionResult RandevuBilgileri()
        {
            var randevular = _context.Randevus.ToList(); // Veritabanındaki randevuları alır
            return View(randevular); // View'e randevu listesini gönderir
        }
    }
}

