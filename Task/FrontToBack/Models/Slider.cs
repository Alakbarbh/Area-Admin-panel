namespace FrontToBack.Models
{
    public class Slider :BaseEntity
    {
        public string? Header { get; set; }
        public string? Description { get; set; }
        public int SliderImageId { get; set; }
        public SliderImage SliderImages { get; set; }
        public string? IsActive { get; set; }
    }
}
