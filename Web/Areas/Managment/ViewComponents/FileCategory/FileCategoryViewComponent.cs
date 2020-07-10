
using Microsoft.AspNetCore.Mvc;
using Domain;
using System.Collections.Generic;

namespace Web.Areas.Managment.ViewComponents
{
    public class FileCategoryViewComponent : ViewComponent
    {
        public  IViewComponentResult Invoke(List<FileCategory> filecategorys)
        {
            return View(filecategorys);
        }
    }
}
