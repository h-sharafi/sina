namespace Domain
{
    public class AudioCms: AuditableEntity<short>
    {
        public File File { get; set; }
        public short FileId { get; set; }
        public string Name { get; set; }
        public AudioCmsType AudioCmsType { get; set; }

    }
    public enum AudioCmsType {
        Type1
    }
}