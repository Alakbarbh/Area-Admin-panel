using FrontToBack.Data;
using FrontToBack.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FrontToBack.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WorkController : Controller
    {

        private readonly AppDbContext _context;
        public WorkController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Recent> recents = await _context.Recents.Where(m => !m.SoftDelete).ToListAsync();
            return View(recents);
        }
    }
}
