using System;
using System.Collections.Generic;
using System.Text;
using Domain.Common;
using Microsoft.AspNetCore.Identity;

namespace Domain
{
    public class AppUser : IdentityUser
    {
        public string DisplayName { get; set; }
        public Team Team { get; set; }
        public DateTime CreationDateTime { get; set; }
        public ICollection<ModifiedUser<Podcast>> PodcastModifiedUser { get; set; }
        public ICollection<ModifiedUser<SiteDetail>> SiteDetailModifiedUsers { get; set; }
        public ICollection<ModifiedUser<Paper>> PaperModifiedUser { get; set; }
        public ICollection<ModifiedUser<Video>> VideoModifiedUser { get; set; }
        public ICollection<ModifiedUser<File>> FileModifiedUser { get; set; }
        public ICollection<ModifiedUser<AccessAbleFile>> AccessAbleFileModifiedUser { get; set; }
        public ICollection<ModifiedUser<ControllerData>> ControllerDataModifiedUser { get; set; }
        public ICollection<ModifiedUser<ActionData>> ActionDataModifiedUser { get; set; }
        public ICollection<Team> CreationTeams { get; set; }


    }
}
