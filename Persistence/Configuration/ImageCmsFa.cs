using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Configuration
{
    public class ImageCmsFa : IEntityTypeConfiguration<ImageCms>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ImageCms> builder)
        {
            // builder
            // .HasOne(m => m.ImageCmsType)
            // .WithMany(fm => fm.ImageCmses)
            // .HasForeignKey(fk => fk.ImageCmsType);

        }
    }
}