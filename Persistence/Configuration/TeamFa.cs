using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.Configuration
{
    public class TeamFa : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder
               .HasOne(m => m.TeamAppUser)
               .WithOne(c => c.Team)
               .HasForeignKey<Team>(fk => fk.TeamAppUserId);


            builder
                .HasOne(m => m.ProfileImage)
                .WithMany(fm => fm.Teams)
                .HasForeignKey(fk => fk.ProfileImageId);

            builder
                .HasOne(m => m.CreationUser)
                .WithMany(fm => fm.CreationTeams)
                .HasForeignKey(fk => fk.CreationUserId);

        }
    }
}
