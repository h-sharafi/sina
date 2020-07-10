using Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using Domain;
using System.Collections.Generic;
using System.Text;

namespace Persistence.Configuration
{
    class PodcastModifiedUserFa : IEntityTypeConfiguration<ModifiedUser<Podcast>>
    {
        public void Configure(EntityTypeBuilder<ModifiedUser<Podcast>> builder)
        {
            builder.HasKey(key => new { key.AppUserId, key.EntityId });
        }
    }
}
