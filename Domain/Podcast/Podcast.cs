﻿using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Podcast : AuditableEntity<short>
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<ModifiedUser<Podcast>> PodcastModifiedUser { get; set; }

    }
}
