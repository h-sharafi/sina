using Application.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.Site.ViewComponents
{
    public class SiteNavbarViewComponent : ViewComponent
    {
        private readonly IContentTypeService _contentTypeService;
        public SiteNavbarViewComponent(IContentTypeService contentTypeService)
        {
            this._contentTypeService = contentTypeService;

        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var models = await _contentTypeService.GetAll().AsNoTracking().Where(c => c.IsActive).OrderBy(ct => ct.DisplaySort).ToListAsync();
            return View(models);
        }
    }
}
