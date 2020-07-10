using System.Collections.Generic;

namespace Domain
{
    public class ImageCms : AuditableEntity<short>
    {
        public File File { get; set; }
        public short FileId { get; set; }
        public string Name { get; set; }
        // public ImageCmsType ImageCmsType { get; set; }
        // public short ImageCmsTypeId { get; set; }

    }
    public class ImageCmsType : AuditableEntity<short>
    {
        public string Name { get; set; }
        public string HtmlText { get; set; }
        // public ICollection<ImageCms> ImageCmses { get; set; }
    }
}