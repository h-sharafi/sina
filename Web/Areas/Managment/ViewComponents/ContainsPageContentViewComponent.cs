using DocumentFormat.OpenXml.Wordprocessing;
using Domain.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.Managment.ViewComponents
{
    public class ContainsPageContentViewComponent : ViewComponent
    {

        public IViewComponentResult Invoke(string name, string controller, string action)
        {

            return View(new ContainsPageContentViewModel
            {
                Name = name, 
                Controller= controller, 
                Action= action
            });
        }
    }
}
