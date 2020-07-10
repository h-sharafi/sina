using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain {
    public class Team : AuditableEntity<short> {
        public AppUser TeamAppUser { get; set; }
        public string TeamAppUserId { get; set; }
        [ForeignKey (nameof (ProfileImageId))]
        public File ProfileImage { get; set; }
        public short? ProfileImageId { get; set; }
        public string BreifKnowledge { get; set; }
        public ICollection<SocialNetwork> SocialNetworks { get; set; }
    }
}