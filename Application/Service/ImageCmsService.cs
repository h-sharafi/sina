using Domain;
using Persistence;
using Microsoft.AspNetCore.Identity;

namespace Application.Service
{
    public interface IImageCmsService : IEntityService<ImageCms>
    {

    }
    public class ImageCmsService : EntityService<ImageCms>, IImageCmsService
    {
        public ImageCmsService(DataContext context, IUserAccessor userAccessor) : base(context, userAccessor)
        {
        }
    }
}