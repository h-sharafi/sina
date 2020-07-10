using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration
{
    public class SliderFa : IEntityTypeConfiguration<Slider>
    {
        public void Configure(EntityTypeBuilder<Slider> builder)
        {
            builder
            .HasOne(m=>m.SliderType)
            .WithMany(fm=>fm.Sliders)
            .HasForeignKey(fk=>fk.SliderTypeId);
        }
    }
}