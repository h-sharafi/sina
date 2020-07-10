using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class SiteSetting : AuditableEntity<short>
    {

        public File SiteLogo { get; set; }
        public short? SiteLogoId { get; set; }
        public File FooterLogo { get; set; }
        public short? FooterLogoId { get; set; }
        public File FavIcon { get; set; }
        public short? FavIconId { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public string FooterText { get; set; }
        public string RightConditionText { get; set; }
        public ICollection<SocialNetwork> SocialNetworks { get; set; }

    }
}