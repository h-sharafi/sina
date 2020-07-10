using System.Threading.Tasks;
using Application.Service;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Web.Areas.Managment.ViewComponents
{
    public class SelectLogoViewComponent : ViewComponent
    {
        private readonly IFileService _fileService;
        public SelectLogoViewComponent(IFileService fileService)
        {
            this._fileService = fileService;
        }

        public async Task<IViewComponentResult> InvokeAsync(short fileId, File file, string typeId)
        {
            if ((file == null || file.Id == 0) && fileId != 0) file = await _fileService.GetAll().AsNoTracking().FirstOrDefaultAsync(file => file.Id == fileId);
            ViewBag.typeId = typeId;
            return View(file);
        }
    }
}