using Domain;
using Domain.Common;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Persistence.Configuration;

namespace Persistence
{
    public class DataContext : IdentityDbContext<AppUser, AppRole, string>
    {
        public DataContext(DbContextOptions options) : base(options) { }
        public DbSet<File> Files { get; set; }
        public DbSet<AccessAbleFile> AccessAbleFiless { get; set; }
        public DbSet<Podcast> Podcasts { get; set; }
        public DbSet<Paper> Papers { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<SiteDetail> SiteDetails { get; set; }

        public DbSet<SiteSetting> SiteSettings { get; set; }
        public DbSet<ControllerData> ControllerDatas { get; set; }
        public DbSet<ActionData> ActionDatas { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<AboutUs> AboutUses { get; set; }
        public DbSet<SocialClass> SocialClasses { get; set; }
        public DbSet<SocialNetwork> SocialNetworks { get; set; }
        public DbSet<ModifiedUser<File>> FileModifiedUser { get; set; }
        public DbSet<FileCategory> FileCategorys { get; set; }
        public DbSet<SideBar> SideBars { get; set; }
        public DbSet<ModifiedUser<AccessAbleFile>> AccessAbleFileModifiedUser { get; set; }
        public DbSet<ModifiedUser<Podcast>> PodcastModifiedUser { get; set; }
        public DbSet<ModifiedUser<Paper>> PaperModifiedUser { get; set; }
        public DbSet<ModifiedUser<Video>> VideoModifiedUser { get; set; }
        public DbSet<ModifiedUser<SiteDetail>> SiteDetailModifiedUser { get; set; }
        public DbSet<ModifiedUser<ControllerData>> ControllerDataModifiedUser { get; set; }
        public DbSet<ModifiedUser<ActionData>> ActionDataModifiedUser { get; set; }
        public DbSet<ContentType> ContentTypes { get; set; }
        public DbSet<AudioCms> AudioCmses { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderType> SliderTypes { get; set; }
        public DbSet<UploadInfo> UploadInfos { get; set; }
        //Error 
        public DbSet<LoggingEvent> LoggingEvents { get; set; }

        #region  Cms
        public DbSet<ImageCms> ImageCmses { get; set; }
        public DbSet<ImageCmsType> ImageCmsTypes { get; set; }
        #endregion  Cms End

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.ApplyConfiguration<ModifiedUser<File>>(new FileModifiedUserFa());
            builder.ApplyConfiguration<ModifiedUser<AccessAbleFile>>(new AccessAbleFileModifiedUserFa());
            builder.ApplyConfiguration<ModifiedUser<Podcast>>(new PodcastModifiedUserFa());
            builder.ApplyConfiguration<ModifiedUser<Video>>(new VideoModifiedUserFa());
            builder.ApplyConfiguration<ModifiedUser<Paper>>(new PaperModifiedUserFa());
            builder.ApplyConfiguration<ModifiedUser<SiteDetail>>(new SiteDetailModifiedUserFa());
            builder.ApplyConfiguration<ModifiedUser<ControllerData>>(new ControllerDataModifiedUserFa());
            builder.ApplyConfiguration<ModifiedUser<ActionData>>(new ActionDataModifiedUserFa());
            // builder.ApplyConfiguration<ContentType>(new ContentTypeFa());
            builder.ApplyConfiguration<Content>(new ContentFa());
            builder.ApplyConfiguration<Slider>(new SliderFa());
            builder.ApplyConfiguration<SocialNetwork>(new SocialNetworkFa());
            builder.ApplyConfiguration<Team>(new TeamFa());

            builder.ApplyConfiguration<SiteSetting>(new SiteSettingFa());
            builder.ApplyConfiguration<FileCategory>(new FileCategoryFa());
            builder.ApplyConfiguration<File>(new FileFa());

            builder.ApplyConfiguration(new ControllerDataFA());



            base.OnModelCreating(builder);
        }
    }
}