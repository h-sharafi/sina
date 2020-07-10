using Domain;
using Persistence;

namespace Application.Service
{
    public interface ISocialNetworkService : IEntityService<SocialNetwork>
    {

    }
    public class SocialNetworkService : EntityService<SocialNetwork>, ISocialNetworkService
    {
        public SocialNetworkService(DataContext context, IUserAccessor userAccessor) : base(context, userAccessor)
        {
        }
    }
}