using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration
{
    public class SiteSettingFa : IEntityTypeConfiguration<SiteSetting>
    {

        public void Configure(EntityTypeBuilder<SiteSetting> builder)
        {

            builder
                .HasOne(im => im.SiteLogo)
                .WithOne(em => em.LogoSiteSetting)
                .HasForeignKey<SiteSetting>(fk => fk.SiteLogoId)
                .OnDelete(DeleteBehavior.Restrict);
            builder
                .HasOne(im => im.FooterLogo)
                .WithOne(em => em.FooterLogoSiteSetting)
                .HasForeignKey<SiteSetting>(fk => fk.FooterLogoId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(im => im.FavIcon)
                .WithOne(em => em.FavIconSetting)
                .HasForeignKey<SiteSetting>(fk => fk.FavIconId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}