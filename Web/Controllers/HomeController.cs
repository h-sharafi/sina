using Microsoft.AspNetCore.Mvc;
using Infrastructure.Attributes;
using System.Threading.Tasks;
using Application.Service;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Web.Controllers
{
    [Title("خانه")]
    [Key("208ed63a-7ab1-4975-a5b8-db8026f89d72")]
    public class HomeController : BaseController
    {
        private readonly ISiteSettingService _siteSettingService;

        public HomeController(ISiteSettingService siteSettingService)
        {
            _siteSettingService = siteSettingService;
        }
        [Title("خانه")]
        [Key("36075378-3e0b-4888-8abd-0e7351a015a1")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [IgnorePermissionCheck]
        public async Task<string> getHeaderLogoFileName()
        {
            var siteSetting = await _siteSettingService.GetAll().Include(s => s.SiteLogo).Select(ss => ss.SiteLogo).FirstOrDefaultAsync();
            return siteSetting != null ? siteSetting.FileName : "logo.png";
        }
    }

}