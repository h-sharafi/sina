using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.Configuration
{
    public class ControllerDataFA : IEntityTypeConfiguration<ControllerData>
    {
        public void Configure(EntityTypeBuilder<ControllerData> builder)
        {
            builder
                 .HasMany(m => m.ActionsList)
                 .WithOne(fm => fm.ControllerData)
                 .HasForeignKey(fk => fk.ControllerDataId);
        }
    }
}
