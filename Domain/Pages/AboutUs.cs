namespace Domain {
    public class AboutUs : AuditableEntity<short> {
        public string Text { get; set; }
        public Team Team { get; set; }
        public short TeamId { get; set; }

    }

 
}