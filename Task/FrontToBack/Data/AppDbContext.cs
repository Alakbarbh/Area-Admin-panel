using FrontToBack.Models;
using Microsoft.EntityFrameworkCore;

namespace FrontToBack.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderImage> SliderImages { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Recent> Recents { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<AboutSlider> AboutSliders { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<ContactSlider> ContactSliders { get; set; }
    }
}
