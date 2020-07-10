using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration
{
    public class FileFa : IEntityTypeConfiguration<File>
    {
        public void Configure(EntityTypeBuilder<File> builder)
        {


            builder
                .HasOne(m => m.Slider)
                .WithMany(fm => fm.Files)
                .HasForeignKey(fk => fk.SliderId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
            .HasOne(m => m.FileCategory)
            .WithMany(fm => fm.Files)
            .HasForeignKey(fk => fk.FileCategoryId)
            .OnDelete(DeleteBehavior.Restrict);

            


        }
    }
}