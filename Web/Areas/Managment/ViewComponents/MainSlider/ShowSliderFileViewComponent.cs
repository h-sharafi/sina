using Application.Service;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.Managment.ViewComponents
{
    public class ShowSliderFileViewComponent: ViewComponent
    {
        private readonly IFileService _fileService;

        public ShowSliderFileViewComponent(IFileService fileService)
        {
            this._fileService = fileService;
        }
        public async Task<IViewComponentResult> InvokeAsync(short fileId)
        {
            var file = await _fileService.GetAll().AsNoTracking().FirstOrDefaultAsync(f => f.Id == fileId);
            return View(file);
        }
    }
}
