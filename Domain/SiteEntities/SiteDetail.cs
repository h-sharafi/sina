using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class SiteDetail : AuditableEntity<short>
    {

        public ICollection<ModifiedUser<SiteDetail>> SiteDetailModifiedUsers { get; set; }

    }
}
