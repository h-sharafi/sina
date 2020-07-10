using Application.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Web.Areas.Managment.ViewComponents.Componrnt
{
    public class ImageComponentViewComponent : ViewComponent
    {
        private readonly IFileService _fileService;

        public ImageComponentViewComponent(IFileService fileService)
        {
            this._fileService = fileService;
        }
        public async System.Threading.Tasks.Task<IViewComponentResult> InvokeAsync(short fileId)
        {
            var file = await _fileService.GetAll().AsNoTracking().FirstOrDefaultAsync(a => a.Id == fileId);
            return View(file);
        }
    }
}