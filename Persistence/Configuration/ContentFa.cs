using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence
{
    public class ContentFa : IEntityTypeConfiguration<Content>
    {
        public void Configure(EntityTypeBuilder<Content> builder)
        {
            builder
                .HasOne(m => m.ContentType)
                .WithMany(fm => fm.Conetnts)
                .HasForeignKey(fk => fk.ContentTypeId);

            builder
                .HasOne(c => c.CoverImage)
                .WithMany(fm => fm.ContentCoverImages)
                .HasForeignKey(fk => fk.CoverImageId);

            builder
                .HasOne(m => m.ProfileImage)
                .WithMany(fm => fm.ContentProfileImages)
                .HasForeignKey(fk => fk.ProfileImageId)
                .OnDelete(DeleteBehavior.Restrict);
                
        }
    }
}