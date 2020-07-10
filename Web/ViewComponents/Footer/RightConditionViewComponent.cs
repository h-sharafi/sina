using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Service;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using Infrastructure.EM;
using Domain.ViewModels;

namespace Web.ViewComponents.Footer
{
    public class RightConditionViewComponent : ViewComponent
    {
        private readonly ISiteSettingService _siteSettingService;

        public RightConditionViewComponent(ISiteSettingService siteSettingService)
        {
            this._siteSettingService = siteSettingService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var rightCondition = await _siteSettingService.GetAll().AsNoTracking().Select(s => new RightConditionViewModel
            {
                RightConditionText = s.RightConditionText
            }).FirstOrDefaultAsync();
            if (rightCondition?.RightConditionText == null)
                rightCondition = new RightConditionViewModel
                {
                    RightConditionText = " "
                };
            return View(rightCondition);
        }
    }
}
