namespace FrontToBack.Models
{
    public class Category : BaseEntity
    {
        public string? Name { get; set; }
        public ICollection<Product> Products { get; set; }
        public string? Filter { get; set; }
    }
}
