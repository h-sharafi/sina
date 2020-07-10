using Domain;
using Persistence;
using Microsoft.AspNetCore.Identity;

namespace Application.Service
{
    public interface ILoggingEventServie : IEntityService<LoggingEvent>
    {
        
    }
    public class LoggingEventService : EntityService<LoggingEvent>, ILoggingEventServie
    {
        public LoggingEventService(DataContext context, IUserAccessor userAccessor) : base(context, userAccessor)
        {
        }
    }
}