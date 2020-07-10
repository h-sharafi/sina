using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class ContentType : AuditableEntity<short>
    {
        public string Name { get; set; }
        public bool IsMainPage { get; set; }
        
        public ICollection<Content> Conetnts { get; set; }
        
    }
}
