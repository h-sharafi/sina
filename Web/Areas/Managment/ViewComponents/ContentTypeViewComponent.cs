using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Service;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Web.Areas.Managment.ViewComponents
{
    public class ContentTypeViewComponent : ViewComponent
    {
        private readonly IContentTypeService _contentTypeService;
        public ContentTypeViewComponent(IContentTypeService contentTypeService)
        {
            this._contentTypeService = contentTypeService;

        }
        public async Task<IViewComponentResult> InvokeAsync(short selectedContentType = 0)
        {
            var contentTypes = await _contentTypeService.GetAll().ToListAsync();
            var tupleModel = new Tuple<List<ContentType>, short>(contentTypes, selectedContentType);
            return View(tupleModel);
        }
    }
}