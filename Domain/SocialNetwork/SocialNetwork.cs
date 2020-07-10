using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain {
    public class SocialNetwork : AuditableEntity<short> {
        public string Name { get; set; }
        public string Address { get; set; }
        public string FaClass { get; set; }
        public SiteSetting SiteSetting { get; set; }
        public short? SiteSettingId { get; set; }
        public Team Team { get; set; }
        public short? TeamId { get; set; }
    }
}