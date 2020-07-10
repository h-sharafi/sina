using Domain;
using Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Text;

namespace Persistence.Configuration
{
    public class FileModifiedUserFa : IEntityTypeConfiguration<ModifiedUser<File>>
    {
        public void Configure(EntityTypeBuilder<ModifiedUser<File>> builder)
        {
            builder.HasKey(key => new { key.AppUserId, key.EntityId });

          
        }
    }
}
