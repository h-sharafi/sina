using Domain;
using Persistence;
using Microsoft.AspNetCore.Identity;

namespace Application.Service
{
    public interface IImageCmsTypeService : IEntityService<ImageCmsType>
    {

    }
    public class ImageCmsTypeService : EntityService<ImageCmsType>, IImageCmsTypeService
    {
        public ImageCmsTypeService(DataContext context, IUserAccessor userAccessor) : base(context, userAccessor)
        {
        }
    }
}