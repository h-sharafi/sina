using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class LoggingEvent : AuditableEntity<int>
    {
        public LogType LogType { get; set; }
        public DateTime DateTime { get; set; }
        [ForeignKey(nameof(AppUserId))]
        public AppUser AppUser { get; set; }
        public string AppUserId { get; set; }
        public string Address { get; set; }

        public string Result { get; set; }
    }
    public enum LogType
    {
        create,
        delete,
        update,
        read,
        error

    }
}