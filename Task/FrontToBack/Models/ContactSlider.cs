using System.Buffers.Text;

namespace FrontToBack.Models
{
    public class ContactSlider : BaseEntity
    {
        public string? Header { get; set; }
        public string? Tittle { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
    }
}
