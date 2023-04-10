namespace FrontToBack.Models
{
    public class TeamMember : BaseEntity
    {
        public string? Image { get; set; }
        public string? Name { get; set; }
        public string? Profession { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }
    }
}
