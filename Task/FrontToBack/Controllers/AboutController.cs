using FrontToBack.Data;
using FrontToBack.Models;
using FrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FrontToBack.Controllers
{
    public class AboutController : Controller
    {

        private readonly AppDbContext _context;
        public AboutController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            AboutSlider aboutSliders = await _context.AboutSliders.FirstOrDefaultAsync();
            IEnumerable<TeamMember> teamMembers = await _context.TeamMembers.Include(m => m.Team).Where(m =>m.SoftDelete == false).ToListAsync();
           
            AboutVM model = new()
            {
                AboutSlider = aboutSliders,
                TeamMembers = teamMembers
            };
            return View(model);
        }
    }
}
