using Infrastructure.Attributes;
using Microsoft.AspNetCore.Mvc;
using VestaEShop.Web.Areas.Management.Controllers;

namespace Web.Areas.Managment.Controllers
{
    [Title("کامپوننت های فایل")]
    [Key("a9b81058-bb64-4fbd-b68d-30caa0b5386d")]
    [Icon("fa fa-dashboard")]
    [IgnorePermissionCheck]
    public class FileComponentController : ManagementController
    {
        public FileComponentController()
        {

        }
        [Title("ایندکس")]
        [Key("6fda4afa-b3fc-4259-a821-f2f9cdedb2fe")]
        [Icon("fa fa-dashboard")]
        public IActionResult Index()
        {
            return View();
        }


    }
}