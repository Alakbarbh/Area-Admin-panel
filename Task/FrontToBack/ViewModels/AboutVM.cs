using FrontToBack.Models;

namespace FrontToBack.ViewModels
{
    public class AboutVM
    {
        public AboutSlider AboutSlider { get; set; }
        public IEnumerable<TeamMember> TeamMembers { get; set; }
        public Team Team { get; set; }
    }
}
