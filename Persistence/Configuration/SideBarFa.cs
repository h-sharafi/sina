using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration
{
    public class SideBarFa : IEntityTypeConfiguration<SideBar>
    {
        public void Configure(EntityTypeBuilder<SideBar> builder)
        {
            builder
            .HasOne(m=>m.Parent)
            .WithMany(m=>m.Childeren)
            .HasForeignKey(fk=>fk.ParentId);
        }
    }
}