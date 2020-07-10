using System.Threading.Tasks;
using Application.Service;
using Infrastructure.Attributes;
using Microsoft.AspNetCore.Mvc;
using VestaEShop.Web.Areas.Management.Controllers;

namespace Web.Areas.Managment.Controllers
{
    [Title("فایل های قابل پذیرش")]
    [Key("f40e78d3-96f2-4677-84ee-c420cf34d83a")]
    [IgnorePermissionCheck]

    public class AccessAbleFileController : ManagementController
    {
        private readonly IAccessAbleFileService _accessAbleFileService;
        public AccessAbleFileController(IAccessAbleFileService accessAbleFileService)
        {
            this._accessAbleFileService = accessAbleFileService;

        }
        [HttpGet]
        [Title("فایل های قابل پذیرش")]
        [ActionName("AccessAbleFile")]
        [Key("500277e6-fe7a-4b2d-aebe-db80915fb89f")]
        public async Task<IActionResult> AccessAbleFile(short id)
        {
            var model =await _accessAbleFileService.GetById(id);
            return View(model);
        }

        

    }


}