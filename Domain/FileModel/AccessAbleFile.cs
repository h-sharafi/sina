using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class AccessAbleFile : AuditableEntity<short>
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public ICollection<File> Files { get; set; }


        public ICollection<ModifiedUser<AccessAbleFile>> AccessAbleFileModifiedUser { get; set; }
    }
}
