using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class Comment : AuditableEntity<short>
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        [ForeignKey(nameof(ContentId))]
        public Content Content { get; set; }
        public short ContentId { get; set; }

        public bool IsRead { get; set; }
        public bool IsAccept { get; set; }
        
        
    }
}