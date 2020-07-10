using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Service;
using Microsoft.EntityFrameworkCore;

namespace Web.ViewComponents
{
    public class PopularPostsViewComponent: ViewComponent
    {
        private readonly IContentService _contentService;

        public PopularPostsViewComponent(IContentService contentService)
        {
            this._contentService = contentService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var content =await _contentService.GetAll().AsNoTracking().Include(c=>c.CoverImage).Include(c=>c.ProfileImage).Include(c=>c.ContentType).Where(c => !c.IsMainPage  && c.IsActive && c.ContentType.IsActive).OrderByDescending(c => c.TotalSeen).Take(4).ToListAsync();
            return View(content);
        }
    }
}
