using System.Collections.Generic;

namespace Domain {
    public class FileCategory : AuditableEntity<short> {
        public string Name { get; set; }
        public FileCategory Parent { get; set; }
        public short? ParentId { get; set; }

        public ICollection<FileCategory> Children { get; set; }
        
        public ICollection<File> Files { get; set; }

    }
}