using Microsoft.AspNetCore.Mvc;
using kuaforr.Data;
using System.Linq;
using System.Threading.Tasks;

namespace kuaforr.Controllers
{
    public class AdminPanelController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminPanelController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Randevular()
        {
            var randevular = _context.Randevus.ToList();
            return View(randevular);
        }

        public IActionResult UyeBilgileri()
        {
            var uyeler = _context.Uyes.ToList();
            return View(uyeler);
        }
    }
}
