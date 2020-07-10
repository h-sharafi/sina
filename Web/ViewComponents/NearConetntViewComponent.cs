using Application.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.ViewComponents
{
    public class NearConetntViewComponent: ViewComponent
    {
        private readonly IContentService _contentService;

        public NearConetntViewComponent(IContentService contentService)
        {
            this._contentService = contentService;
        }
        public async Task<IViewComponentResult> InvokeAsync(short id)
        {
            var conetnts =await _contentService.GetAll().AsNoTracking().Include(c=>c.CoverImage).Include(c=>c.ContentType).Where(c=>c.ContentTypeId== id&& c.IsActive).OrderBy(c => c.TotalSeen).Take(3).ToListAsync();
            return View(conetnts);
        }
    }
}
