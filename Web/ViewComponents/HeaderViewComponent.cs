using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Application.Service;
using Microsoft.EntityFrameworkCore;

namespace Web.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly ISocialNetworkService _socialNetworkService;
            private readonly ISiteSettingService _siteSettingService;

        public HeaderViewComponent(ISocialNetworkService socialNetworkService, ISiteSettingService siteSettingService)
        {
            this._socialNetworkService = socialNetworkService;
            this._siteSettingService = siteSettingService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var socialBetwork = await _socialNetworkService.GetAll().AsNoTracking().Where(sn => sn.TeamId == null).ToListAsync();
            var siteSetting = await _siteSettingService.GetAll().AsNoTracking().Include(s => s.SiteLogo).FirstOrDefaultAsync();
            if (socialBetwork == null) socialBetwork = new List<SocialNetwork>();

            var model = new Tuple<List<SocialNetwork>, SiteSetting>(socialBetwork, siteSetting);

            return View(model);
        }
    }
}
