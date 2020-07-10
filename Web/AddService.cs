using Application;
using Application.Service;
using Domain;
using Microsoft.Extensions.DependencyInjection;

namespace Web
{
    public static class AddServiceEM
    {
        public static IServiceCollection AddService(this IServiceCollection services)
        {

            //services.AddScoped<IEntityService<Team>, EntityService<Team>> ();
            services.AddScoped<IFileCategoryService, FileCategoryService>();
            services.AddScoped<ISideBarService, SideBarService>();
            services.AddScoped<ICommentService, CommentService>();
            services.AddScoped<ISiteSettingService, SiteSettingService>();
            services.AddScoped<ITeamService, TeamService>();
            services.AddScoped<IAccessAbleFileService, AccessAbleFileService>();
            services.AddScoped<IContentService, ContentService>();
            services.AddScoped<ILoggingEventServie, LoggingEventService>();
            services.AddScoped<IContentTypeService, ContentTypeService>();
            services.AddScoped<IAudioCmsService, AudioCmsService>();
            services.AddScoped<ISliderService, SliderService>();
            services.AddScoped<ISliderTypeService, SliderTypeService>();
            services.AddScoped<IUploadInfoService, UploadInfoService>();
            services.AddScoped<IControllerDataService, ControllerDataService>();
            services.AddScoped<IImageCmsService, ImageCmsService>();
            services.AddScoped<IImageCmsTypeService, ImageCmsTypeService>();
            services.AddScoped<IUserAccessor, UserAccessor>();
            services.AddScoped<ITeamService, TeamService>();
            services.AddScoped<ISocialNetworkService, SocialNetworkService>();

            services.AddScoped<IFileService, FileService>();

            return services;
        }
    }
}