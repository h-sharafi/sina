using Domain;
using Persistence;
using Microsoft.AspNetCore.Identity;

namespace Application.Service
{
    public interface ISliderTypeService: IEntityService<SliderType>
    {
        
    }
    public class SliderTypeService : EntityService<SliderType>, ISliderTypeService
    {
        public SliderTypeService(DataContext context, IUserAccessor userAccessor) : base(context, userAccessor){}
    }
}