using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Service;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using Infrastructure.EM;
using Domain;

namespace Web.ViewComponents.Footer
{
    public class FooterLogoViewComponent: ViewComponent
    {
        private readonly ISiteSettingService _siteSettingService;

        public FooterLogoViewComponent(ISiteSettingService siteSettingService)
        {
            this._siteSettingService = siteSettingService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var siteSetting =await _siteSettingService.GetAll().AsNoTracking().Include(f=>f.FooterLogo).FirstOrDefaultAsync();
            return View(siteSetting);
        }
    }
}
