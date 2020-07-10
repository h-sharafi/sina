using Domain.ViewModels.FileFolder;
using Microsoft.AspNetCore.Mvc;
using Application.Service;
using Domain;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace Web.Areas.Managment.ViewComponents
{
    public class AddFileCategoryViewComponent : ViewComponent
    {
        private readonly IFileCategoryService _fileCategoryService;
        public AddFileCategoryViewComponent(IFileCategoryService fileCategoryService)
        {
            this._fileCategoryService = fileCategoryService;
        }
        public async Task<IViewComponentResult> InvokeAsync(short? id)
        {
            var fileCategory = new FileCategory();
            if (id != null) fileCategory = await _fileCategoryService.GetAll().AsNoTracking().FirstOrDefaultAsync(fileCategory => fileCategory.Id == id);
             var dictionary = new SelectList(await _fileCategoryService.GetDictionaryAsync(), "Key", "Value", id);
            return View(new Tuple<FileCategory, SelectList>(fileCategory, dictionary));
        }
    }

}