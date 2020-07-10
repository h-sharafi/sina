using Microsoft.AspNetCore.Mvc;
using Application.Service;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Domain;
using System.Collections.Generic;
using System;
using Domain.ViewModels;

namespace Web.Areas.Managment.ViewComponents
{
    public class SelectFileCategoryChilderenViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(short selectedId, List<FileCategory> fileCategorys, string selectFileCategoryCls)
        {
            return View(new SelectFileCategoryViewModel
            {
                SelectedId = selectedId,
                FileCategorys = fileCategorys, 
                SelectFileCategoryCls = selectFileCategoryCls
            });
        }
    }
}