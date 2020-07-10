using System.Linq;
using System.Threading.Tasks;
using Application.Service;
using Microsoft.AspNetCore.Mvc;
using Infrastructure.EM;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Domain;

namespace Web.Areas.Managment.ViewComponents
{
    public class SelectFileViewComponent : ViewComponent
    {
        private readonly IFileService _fileService;
        private readonly IFileCategoryService _fileCategoryService;
        public SelectFileViewComponent(IFileService fileService, IFileCategoryService fileCategoryService)
        {
            this._fileCategoryService = fileCategoryService;
            this._fileService = fileService;

        }
        public async Task<IViewComponentResult> InvokeAsync(short? selectedFileId, int? selectedFileCategoryId, int pageIndex, short pageSize)
        {
            pageIndex = pageIndex == 0 ? pageIndex = 1 : pageIndex;
            pageSize = pageSize == 0 ? pageSize=12: pageSize;
            var model = _fileService.GetAll();
            if (selectedFileCategoryId != null)
                model = model.Where(fc => fc.FileCategoryId == selectedFileCategoryId);
            var retungPagingViewModel = model.Paging(pageIndex, pageSize);
            var modelResult = await retungPagingViewModel.RetunIQueryableModel.AsNoTracking().ToListAsync();
            var tupleModel = new Tuple<List<File>, int, int, int>(modelResult, retungPagingViewModel.PageIndex, retungPagingViewModel.TotalPage, retungPagingViewModel.PageSize);
            return View(tupleModel);
        }
    }
}