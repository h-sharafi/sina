using Domain;
using Microsoft.AspNetCore.Identity;
using Persistence;

namespace Application.Service {
    public interface IContentService : IEntityService<Content> {

    }
    public class ContentService : EntityService<Content>, IContentService {
        public ContentService(DataContext context, IUserAccessor userAccessor) : base(context, userAccessor) { }
    }
}