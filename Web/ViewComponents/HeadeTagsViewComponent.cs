using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Application.Service;
using Microsoft.EntityFrameworkCore;
using DocumentFormat.OpenXml.Spreadsheet;

namespace Web.ViewComponents
{
    public class HeadeTagsViewComponent : ViewComponent
    {
        private readonly ISiteSettingService _siteSettingService;

        public HeadeTagsViewComponent(ISiteSettingService siteSettingService)
        {
            this._siteSettingService = siteSettingService;
        }
        public async Task<IViewComponentResult> InvokeAsync(string pagePlace)
        {
            var sjgif = _siteSettingService.GetAll().Include(f => f.FavIcon).ThenInclude(f => f.FavIconSetting);
            var siteSetting = await _siteSettingService.GetAll().AsNoTracking().Include(s => s.FavIcon).FirstOrDefaultAsync();
            var model = new Tuple<SiteSetting, string>(siteSetting, pagePlace);
            return View(model);
        }
    }
}
