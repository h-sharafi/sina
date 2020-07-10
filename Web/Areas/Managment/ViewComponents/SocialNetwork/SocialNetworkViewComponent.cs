using Microsoft.AspNetCore.Mvc;
using Application.Service;
using System.Collections.Generic;
using Domain;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;

namespace Web.Areas.Managment.ViewComponents
{
    public class SocialNetworkViewComponent : ViewComponent
    {
        private readonly ISocialNetworkService _socialNetworkService;
        private readonly ISiteSettingService _siteSettingService;
        public SocialNetworkViewComponent(ISocialNetworkService socialNetworkService, ISiteSettingService siteSettingService)
        {
            this._siteSettingService = siteSettingService;
            this._socialNetworkService = socialNetworkService;

        }
        public async System.Threading.Tasks.Task<IViewComponentResult> InvokeAsync(short? teamId)
        {
            var socialNetwork = teamId != null ?
                await _socialNetworkService.GetAll().AsNoTracking().Where(s => s.TeamId == teamId).ToListAsync()
                : await _socialNetworkService.GetAll().AsNoTracking().Where(s => s.SiteSettingId != null).ToListAsync();
            var model = new Tuple<List<SocialNetwork>, short?>(socialNetwork, teamId);
            return View(model);
        }
    }
}