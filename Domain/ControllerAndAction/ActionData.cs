using Domain;
using Domain.Common;
using System.Collections.Generic;

namespace Domain
{
    public class ActionData : AuditableEntity<short>
    {
        public string ActionName { get; set; }
        public string ActionNameLocalized { get; set; }
        public string ActionIcon { get; set; }
        public bool AllowAnonymous { get; set; }
        public bool RequiresAuthorization { get; set; }
        public bool RequiresHttpPost { get; set; }
        public string Url {get; set;}
        public string Key { get; set; }
        public bool IsDontSideBarShow { get; set; }
        public ControllerData ControllerData { get; set; }
        public short ControllerDataId { get; set; }
        public ICollection<ModifiedUser<ActionData>> ActionDataModifiedUser { get; set; }
    }
}