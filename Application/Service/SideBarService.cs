using Domain;
using Persistence;
using Microsoft.AspNetCore.Identity;

namespace Application.Service
{
    public interface ISideBarService: IEntityService<SideBar>
    {
        
    }
    public class SideBarService : EntityService<SideBar>, ISideBarService
    {
        public SideBarService(DataContext context, IUserAccessor userAccessor) : base(context, userAccessor)
        {
        }
    }
}