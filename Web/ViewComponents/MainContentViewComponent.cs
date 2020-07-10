using Application.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.Site.ViewComponents
{
    public class MainContentViewComponent : ViewComponent
    {
        private readonly IContentTypeService _contentTypeService;
        private readonly IContentService _contentService;
        public MainContentViewComponent(IContentTypeService contentTypeService, IContentService contentService)
        {
            this._contentService = contentService;
            this._contentTypeService = contentTypeService;

        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var contentTypeList = await _contentTypeService.GetAll().AsNoTracking().Select(c => c.Id).ToListAsync();
            var list = new List<Domain.Content>();
            contentTypeList.ForEach(id =>
           {
               var result = _contentService.GetAll().AsNoTracking().Include(c => c.ContentType).Where(c => c.IsActive && c.ContentType.IsActive).Include(c => c.CoverImage).Include(p=>p.ProfileImage).OrderByDescending(c => c.CreationTime).FirstOrDefault(c => c.ContentTypeId == id);
               if (result != null) list.Add(result);
           });
            return View(list);
        }
    }
}
