using FrontToBack.Data;
using FrontToBack.Models;
using FrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FrontToBack.Controllers
{
    public class ContactController : Controller
    {

        private readonly AppDbContext _context;
        public ContactController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            ContactSlider contactSlider = await _context.ContactSliders.FirstOrDefaultAsync();

            ContactVM model = new()
            {
                ContactSlider = contactSlider,
            };
            return View(model);
        }
    }
}
