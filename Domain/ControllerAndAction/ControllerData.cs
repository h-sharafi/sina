using Domain;
using Domain.Common;
using System.Collections.Generic;

namespace Domain
{
    public class ControllerData : AuditableEntity<short>
    {
        public string ControllerName { get; set; }
        public string ControllerIcon { get; set; }
        public string ControllerNameLocalized { get; set; }
        public string ControllerNamespace { get; set; }
        public bool RequiresAuthorization { get; set; }
        public string Key { get; set; }
        public bool IsDontSideBarShow { get; set; }
        public ICollection<ActionData> ActionsList { get; set; }
        public ICollection<ModifiedUser<ControllerData>> ControllerDataModifiedUser { get; set; }
        

    }
}