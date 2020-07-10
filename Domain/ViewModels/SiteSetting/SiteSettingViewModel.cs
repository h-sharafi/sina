using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.ViewModels
{
    public class SiteSettingViewModel : AuditableEntity<short>
    {
        public File SiteLogo { get; set; }
        public File FooterLogo { get; set; }
        public File FavIcon { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public short SiteLogoId { get; set; }
        public short FooterLogoId { get; set; }
        public short FavIconId { get; set; }
        public string RightConditionText { get; set; }
        public string FooterText { get; set; }

    }
}
