using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    public class Entity<T> : IEntity<T>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public T Id { get; set; }
        [Display(Name ="فعال/ غیره فعال")]
        public bool IsActive { get; set; }

        public byte DisplaySort { get; set; }
        public AppUser CreationUser { get; set; }
        public string CreationUserId { get; set; }
        public ICollection<AppUser> ModifiedUser { get; set; }
        [Display(Name ="زمان ایجاد")]
        public DateTime CreationTime { get; set; }
        [Display(Name ="تعداد بازدید")]
        public int TotalSeen { get; set; }
    }
}
