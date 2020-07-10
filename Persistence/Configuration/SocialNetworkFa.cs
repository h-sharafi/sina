using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.Configuration
{
    public class SocialNetworkFa : IEntityTypeConfiguration<SocialNetwork>
    {
        public void Configure(EntityTypeBuilder<SocialNetwork> builder)
        {
            builder
                .HasOne(c => c.SiteSetting)
                .WithMany(fm => fm.SocialNetworks)
                .HasForeignKey(fk => fk.SiteSettingId);
            builder
               .HasOne(c => c.Team)
               .WithMany(fm => fm.SocialNetworks)
               .HasForeignKey(fk => fk.TeamId);
        }
    }
}
