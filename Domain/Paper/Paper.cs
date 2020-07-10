using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Paper : AuditableEntity<short>
    {
        public string Name { get; set; }
        public string title { get; set; }
        public string Description { get; set; }

        public ICollection<ModifiedUser<Paper>> PaperModifiedUser { get; set; }
    }
}
