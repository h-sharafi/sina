using Domain;
using Persistence;
using Microsoft.AspNetCore.Identity;

namespace Application.Service
{
    public interface IAudioCmsService: IEntityService<AudioCms>
    {
        
    }
    public class AudioCmsService : EntityService<AudioCms>, IAudioCmsService
    {
        public AudioCmsService(DataContext context, IUserAccessor userAccessor) : base(context, userAccessor)
        {
        }
    }
}