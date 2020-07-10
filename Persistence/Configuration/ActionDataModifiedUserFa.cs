using Domain;
using Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.Configuration
{
    public class ActionDataModifiedUserFa : IEntityTypeConfiguration<ModifiedUser<ActionData>>
    {
        public void Configure(EntityTypeBuilder<ModifiedUser<ActionData>> builder)
        {
            builder.HasKey(key => new { key.AppUserId, key.EntityId });
        }
    }
}