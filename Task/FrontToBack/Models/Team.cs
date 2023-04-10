namespace FrontToBack.Models
{
    public class Team : BaseEntity
    {
        public string? Header { get; set; }
        public string? Description { get; set; }
        public ICollection<TeamMember> TeamMember { get; set; }
    }
}
