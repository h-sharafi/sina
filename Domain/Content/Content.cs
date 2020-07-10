using System.Collections.Generic;

namespace Domain
{
    public class Content : AuditableEntity<short>
    {

        public ICollection<Comment> Comments { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Keywords { get; set; }
        public string Text { get; set; }
        public bool IsMainPage { get; set; }
        public ContentType ContentType { get; set; }
        public short ContentTypeId { get; set; }
        public string Name { get; set; }
        public File CoverImage { get; set; }
        public short CoverImageId { get; set; }
        public File ProfileImage { get; set; }
        public short ProfileImageId { get; set; }
   


    }
}