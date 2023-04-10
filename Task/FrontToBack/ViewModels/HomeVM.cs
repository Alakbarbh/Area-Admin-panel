using FrontToBack.Models;
using System.Reflection.Metadata;

namespace FrontToBack.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Slider> Slider { get; set; }
        public Service Service { get; set; }
        public IEnumerable<Recent> Recent { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Product> Products { get; set; }
        
    }
}
