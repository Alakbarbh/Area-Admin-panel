using FrontToBack.Data;
using FrontToBack.Models;
using FrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Composition;
using System.Diagnostics;
using System.Reflection.Metadata;
using static System.Reflection.Metadata.BlobBuilder;

namespace FrontToBack.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Slider> sliders = await _context.Sliders.Include(m=>m.SliderImages).Where(m => !m.SoftDelete).ToListAsync();
            Service services = await _context.Services.FirstOrDefaultAsync();
            IEnumerable<Recent> recents = await _context.Recents.Where(m => !m.SoftDelete).ToListAsync();
            IEnumerable<Category> categories = await _context.Categories.Where(m => !m.SoftDelete).ToListAsync();
            IEnumerable<Product> products = await _context.Products.Include(m => m.ProductImages).Where(m => !m.SoftDelete).ToListAsync();
            HomeVM model = new()
            {
                Slider = sliders,
                Service = services,
                Recent = recents,
                Categories = categories,
                Products = products
            };

            return View(model);
        }

    }
}