using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Service;
using Microsoft.AspNetCore.Mvc;
using Infrastructure.EM;
using Microsoft.EntityFrameworkCore;
using Domain;

namespace Web.Areas.Managment.ViewComponents
{
    public class ComponentFileShowViewComponent : ViewComponent
    {
        private readonly IFileService _fileService;
        public ComponentFileShowViewComponent(IFileService fileService)
        {
            this._fileService = fileService;

        }
        public async Task<IViewComponentResult> InvokeAsync(string fileType, int pageIndex = 1, int pageSize = 12, short? fileCategoryId = null, string selectFileClass = null)
        {

            var model = _fileService.GetAll();
            model = fileType != null ? model.Where(file => file.FileType.Contains(fileType)) : model;
            if (fileCategoryId != null)
                model = model.Where(fc => fc.FileCategoryId == fileCategoryId);
            var retungPagingViewModel = model.Paging(pageIndex, pageSize);
            var modelResult = await retungPagingViewModel.RetunIQueryableModel.AsNoTracking().ToListAsync();
            var tupleModel = new Tuple<List<File>, int, int, int, string, short?>(modelResult, retungPagingViewModel.PageIndex, retungPagingViewModel.TotalPage, retungPagingViewModel.PageSize, selectFileClass, fileCategoryId);
            return View(tupleModel);
        }
    }
}