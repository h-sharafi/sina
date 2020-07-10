using Domain;
using Persistence;

namespace Application.Service
{
    public interface ITeamService : IEntityService<Team>
    {

    }
    public class TeamService : EntityService<Team>, ITeamService
    {
        public TeamService(DataContext context, IUserAccessor userAccessor) : base(context, userAccessor)
        {
        }
    }
}