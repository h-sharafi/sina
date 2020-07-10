using Domain;
using Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.Configuration
{
    public class ControllerDataModifiedUserFa : IEntityTypeConfiguration<ModifiedUser<ControllerData>>
    {
        public void Configure(EntityTypeBuilder<ModifiedUser<ControllerData>> builder)
        {
            builder.HasKey(key => new { key.AppUserId, key.EntityId });
        }
    }
}
