using System.Collections.Generic;

namespace Domain
{
    public class Slider: AuditableEntity<short>
    {
        public ICollection<File> Files { get; set; }
        public string Name { get; set; }
        public SliderType SliderType { get; set; }
        public short? SliderTypeId { get; set; }
    }
}