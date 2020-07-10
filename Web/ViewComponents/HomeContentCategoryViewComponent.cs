using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Service;
using DocumentFormat.OpenXml.Bibliography;
using Microsoft.EntityFrameworkCore;

namespace Web.ViewComponents
{
    public class HomeContentCategoryViewComponent : ViewComponent
    {
        private readonly IContentTypeService _contentTypeService;

        public HomeContentCategoryViewComponent(IContentTypeService contentTypeService)
        {
            this._contentTypeService = contentTypeService;
            
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var contentTypes = await _contentTypeService.GetAll().AsNoTracking().Where(c=>c.IsActive).Include(c => c.Conetnts).OrderByDescending(c => c.Conetnts.Count).ToListAsync();
            return View(contentTypes);
        }
    }
}
