namespace Domain {
    public class SocialClass : AuditableEntity<short> {
        public string Name { get; set; }
        public string Address { get; set; }
        public string FaClass { get; set; }
    }
}