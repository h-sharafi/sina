using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration
{
    public class ContentTypeFa : IEntityTypeConfiguration<ContentType>
    {
        public void Configure(EntityTypeBuilder<ContentType> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}