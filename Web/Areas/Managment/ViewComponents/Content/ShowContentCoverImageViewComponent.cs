using System.Threading.Tasks;
using Application.Service;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Web.Areas.Managment.ViewComponents
{
    public class ShowContentCoverImageViewComponent : ViewComponent
    {
        private readonly IFileService _fileService;
        public ShowContentCoverImageViewComponent(IFileService fileService)
        {
            this._fileService = fileService;
        }

        public async Task<IViewComponentResult> InvokeAsync(short fileId, File file, string tagId)
        {
            if ((file == null || file.Id == 0) && fileId != 0) file = await _fileService.GetAll().AsNoTracking().FirstOrDefaultAsync(file => file.Id == fileId);
            ViewBag.tagId = tagId;
            return View(file);
        }
    }
}