using Domain;
using Microsoft.AspNetCore.Identity;
using Persistence;

namespace Application.Service
{
    public interface ICommentService:IEntityService<Comment>
    {
        
    }
    public class CommentService : EntityService<Comment>, ICommentService
    {
        public CommentService(DataContext context, IUserAccessor userAccessor) : base(context, userAccessor) //(DataContext context, IUserAccessor userAccessor) : base(context, userAccessor)
        {
        }
    }
}