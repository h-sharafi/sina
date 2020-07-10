using Domain;
using Persistence;
using Microsoft.AspNetCore.Identity;

namespace Application.Service
{
    public interface ISliderService: IEntityService<Slider>
    {
        
    }
    public class SliderService : EntityService<Slider>, ISliderService
    {
        public SliderService(DataContext context, IUserAccessor userAccessor) : base(context, userAccessor)
        {
            
        }
    }
}