using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Common
{
    public class ModifiedUser<T> where T : class
    {
        [ForeignKey(nameof(AppUserId))]
        public AppUser AppUser { get; set; }
        public string AppUserId { get; set; }

        public T Entity { get; set; }
        public short EntityId { get; set; }

    }
}
