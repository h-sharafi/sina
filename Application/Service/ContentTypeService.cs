using Domain;
using Persistence;
using Microsoft.AspNetCore.Identity;

namespace Application.Service
{
    public interface IContentTypeService: IEntityService<ContentType>
    {
        
    }
    public class ContentTypeService : EntityService<ContentType>, IContentTypeService
    {
        public ContentTypeService(DataContext context, IUserAccessor userAccessor) : base(context, userAccessor)
        {

        }
    }
}