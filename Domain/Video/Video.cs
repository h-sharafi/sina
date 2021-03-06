﻿using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Video : AuditableEntity<short>
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<ModifiedUser<Video>> VideoModifiedUser { get; set; }

    }
}
