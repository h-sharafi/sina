using Microsoft.AspNetCore.Mvc;
using Application.Service;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Domain;
using System.Collections.Generic;
using System;

namespace Web.Areas.Managment.ViewComponents
{
    public class SelectFileCategoryViewComponent : ViewComponent
    {
        private readonly IFileCategoryService _fileCategory;
        public SelectFileCategoryViewComponent(IFileCategoryService fileCategory)
        {
            this._fileCategory = fileCategory;
        }
        public async Task<IViewComponentResult> InvokeAsync(short selectedId, string selectFileCategoryCls)
        {
            var fileCategorys = await _fileCategory.GetAll().Where(fc => fc.ParentId == null).Include(f => f.Children).ThenInclude(f => f.Children).ThenInclude(f => f.Children).ThenInclude(f => f.Children).ThenInclude(f => f.Children).ToListAsync();

            return View(new Tuple<List<FileCategory>, short, string>(fileCategorys, selectedId, selectFileCategoryCls));
        }
    }
}