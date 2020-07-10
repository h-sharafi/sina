using System.Collections.Generic;
using Domain;
using Domain.ViewModels.SideBar;

namespace Domain.ViewModels
{
    public class SideBarViewModel
    {
        public string Menu { get; set; }
        public string SubMenu { get; set; }
        public AppUser User { get; set; }
        public SiteSetting SiteSetting { get; set; }
        public List<ControllerData> SideBars { get; set; }
    }
}