using System.Linq;
using System.Threading.Tasks;
using Application.Service;
using Domain.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Web.Areas.Managment.ViewComponents
{
    public class SideBarViewComponent : ViewComponent
    {
        private readonly IUserService _userService;
        private readonly IControllerDataService _controllerDataService;
        private readonly ISiteSettingService _siteSettingService;

        public SideBarViewComponent(IControllerDataService controllerDataService, IUserService userService, ISiteSettingService siteSettingService)
        {
            this._siteSettingService = siteSettingService;
            this._controllerDataService = controllerDataService;
            this._userService = userService;
        }
        public async Task<IViewComponentResult> InvokeAsync(string menu, string subMenu)
        {
            var user = await _userService.GetAll().Include(u=>u.Team).ThenInclude(t=>t.ProfileImage).FirstOrDefaultAsync(user => user.UserName == HttpContext.User.Identity.Name);
            var sideBars = await _controllerDataService.GetSideBar();
            var siteSetting = await _siteSettingService.GetAll().AsNoTracking().Include(c => c.SiteLogo).FirstOrDefaultAsync();

            return View(new SideBarViewModel
            {
                Menu = menu,
                SubMenu = subMenu,
                User = user,
                SideBars = sideBars,
                SiteSetting = siteSetting
            });
        }
    }
}