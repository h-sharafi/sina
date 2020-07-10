using Domain;
using Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration
{
    public class SiteDetailModifiedUserFa : IEntityTypeConfiguration<ModifiedUser<SiteDetail>>
    {
        public void Configure(EntityTypeBuilder<ModifiedUser<SiteDetail>> builder)
        {
            builder.HasKey(key => new { key.AppUserId, key.EntityId });
        }
    }
}
