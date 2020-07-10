using System.Collections;
using System.Collections.Generic;

namespace Domain
{
    public class SideBar: AuditableEntity<short>
    {
        public AppUser AppUser { get; set; }
        
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Url { get; set; }
        public SideBar Parent { get; set; }
        public short? ParentId { get; set; }
        public ICollection<SideBar> Childeren { get; set; }
    }
}