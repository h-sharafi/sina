using Domain;
using Persistence;
using Microsoft.AspNetCore.Identity;

namespace Application.Service
{
    public interface ISiteSettingService: IEntityService<SiteSetting>
    {
        
    }
    public class SiteSettingService : EntityService<SiteSetting>, ISiteSettingService
    {
        public SiteSettingService(DataContext context, IUserAccessor userAccessor) : base(context, userAccessor)
        {
        }
    }
}