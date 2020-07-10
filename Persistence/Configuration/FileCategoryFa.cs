using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration {
    public class FileCategoryFa : IEntityTypeConfiguration<FileCategory>

        {
            public void Configure (EntityTypeBuilder<FileCategory> builder) {
                builder
                    .HasOne (m => m.Parent)
                    .WithMany (fm => fm.Children)
                    .HasForeignKey (fk => fk.ParentId)
                    .OnDelete (DeleteBehavior.Restrict);
            }
        }
}