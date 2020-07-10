using Domain;
using Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.Configuration
{
    public class VideoModifiedUserFa : IEntityTypeConfiguration<ModifiedUser<Video>>
    {
        public void Configure(EntityTypeBuilder<ModifiedUser<Video>> builder)
        {
            builder.HasKey(key => new { key.AppUserId, key.EntityId });
        }
    }
}
