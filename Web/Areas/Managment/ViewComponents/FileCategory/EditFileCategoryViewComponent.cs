using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Service;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Web.Areas.Managment.ViewComponents
{
    public class EditFileCategoryViewComponent : ViewComponent
    {
        private readonly IFileCategoryService _fileCategoryService;
        public EditFileCategoryViewComponent(IFileCategoryService fileCategoryService)
        {
            this._fileCategoryService = fileCategoryService;
        }
        public async Task<IViewComponentResult> InvokeAsync(short? id)
        {
            var fileCategory = new FileCategory();
            if (id != null) fileCategory = await _fileCategoryService.GetAll().AsNoTracking().FirstOrDefaultAsync(fileCategory => fileCategory.Id == id);
            var dictionary = new SelectList(await _fileCategoryService.GetDictionaryAsync(), "Key", "Value",id);      
            return View(new Tuple<FileCategory , SelectList>(fileCategory,  dictionary));
        }
    }
}