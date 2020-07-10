using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Domain.ViewModels.SideBar;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Persistence;

namespace Application.Service
{
    public interface IControllerDataService : IEntityService<ControllerData>
    {
        Task<List<ControllerData>> GetSideBar();
    }
    public class ControllerDataService : EntityService<ControllerData>, IControllerDataService
    {
        public ControllerDataService(DataContext context, IUserAccessor userAccessor) : base(context, userAccessor)
        {
        }

        public async Task<List<ControllerData>> GetSideBar()
        {
            //    return await (from controllerDatas in GetAll().Where(ac => !ac.IsDontSideBarShow)
            //                        join actionDatas in _context.ActionDatas.Where(ac => !ac.IsDontSideBarShow && !ac.RequiresHttpPost) on controllerDatas.Id equals actionDatas.ControllerDataId
            //                        select new returnSideBarViewModel
            //                        {
            //                            ControllerData = controllerDatas, 
            //                            ActionData = actionDatas
            //                        }).ToListAsync();

            return await GetAll().Include(c => c.ActionsList).Where(ac => !ac.IsDontSideBarShow).ToListAsync();
        }
    }

}