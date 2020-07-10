using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Application.Service;
using AutoMapper;
using Domain;
using Domain.ViewModels;
using Infrastructure.Attributes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VestaEShop.Web.Areas.Management.Controllers;

namespace Web.Areas.Managment.Controllers
{
    [Title("تنظیمات")]
    [Key("798101b8-71a7-4458-afc5-3a290446be30")]
    [Icon("fa fa-dashboard")]
    public class SiteSettingController : ManagementController
    {
        private readonly ISiteSettingService _siteSettingService;
        private readonly IMapper _mapper;
        private readonly IFileService _fileService;
        private readonly ITeamService _teamService;
        private readonly UserManager<AppUser> _userManager;
        private readonly IUserService _userService;
        private readonly ISocialNetworkService _socialNetworkService;
        private readonly ISliderService _sliderService;

        public SiteSettingController(ISiteSettingService siteSettingService, IMapper mapper, IFileService fileService, ITeamService teamService
            , UserManager<AppUser> userManager, IUserService userService, ISocialNetworkService socialNetworkService, ISliderService sliderService)
        {
            this._sliderService = sliderService;
            this._socialNetworkService = socialNetworkService;
            this._userManager = userManager;
            this._userService = userService;
            this._siteSettingService = siteSettingService;
            this._mapper = mapper;
            this._fileService = fileService;
            this._teamService = teamService;
        }
        [Title("تنظیمات")]
        [Key("4b46551c-f511-444c-a7a8-7332b84b2da2")]
        [Icon("fa fa-dashboard")]
        public async Task<IActionResult> Index()
        {
            var siteSetting = await _siteSettingService.GetAll().AsNoTracking().Include(s => s.SiteLogo).Include(s => s.FooterLogo).Include(s => s.FavIcon).FirstOrDefaultAsync();
            if (siteSetting == null)
            {
                siteSetting = new SiteSetting
                {
                    Name = "Site Name",
                    Title = "site title",
                    Description = "siteDes"
                };
                await _siteSettingService.Create(siteSetting);
            }
            return View(_mapper.Map<SiteSettingViewModel>(siteSetting));
        }
        [HttpPost]
        [Title("-postتنظیمات")]
        [Key("5a39ab94-400b-4d4a-ba6f-29193063a295")]
        [Icon("fa fa-dashboard")]
        [DontSideBarShow]
        public async Task<IActionResult> Index(SiteSettingViewModel model)
        {
            if (ModelState.IsValid)
            {
                var baseSiteSetting = await _siteSettingService.GetAll().AsNoTracking().FirstOrDefaultAsync();

                baseSiteSetting.SiteLogoId = model.SiteLogoId;
                baseSiteSetting.FooterLogoId = model.FooterLogoId;
                baseSiteSetting.FavIconId = model.FavIconId;

                baseSiteSetting.Name = model.Name;
                baseSiteSetting.Title = model.Title;
                baseSiteSetting.Description = model.Description;
                baseSiteSetting.FooterText = model.FooterText;
                baseSiteSetting.RightConditionText = model.RightConditionText;

                await _siteSettingService.Update(baseSiteSetting);
                return RedirectToAction("Index", "SiteSetting");
            }
            return View(model);
        }
        public IActionResult GetIndex()
        {
            return PhysicalFile(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "index.html"), "text/HTML");
        }
        [HttpPost]
        [IgnorePermissionCheck]
        public IActionResult ReturnLogoImage(Domain.File file, short fileId, string typeId)
        {
            return ViewComponent("SelectLogo", new { file = file.Id != 0 ? file : null, fileId = fileId, typeId = typeId });
        }
        [IgnoreAntiforgeryToken]
        private async Task<Domain.File> GetFileAsync(IFormFile file, string title, string description)
        {
            var result = await _fileService.Upload(file);

            var logoFile = new Domain.File();
            if (result != null)
            {
                return await _fileService.Create(new Domain.File
                {
                    Name = result,
                    Title = title,
                    Description = description
                });

            }
            else
            {
                throw new Exception("فایل قابل دانلود نیست ");
            }
        }
        [Title("تیم")]
        [Key("423d871b-d97f-4989-95c1-55e3dccc63aa")]
        [Icon("fa fa-dashboard")]
        public async Task<IActionResult> TeamList()
        {
            var teams = await _teamService.GetAll().AsNoTracking().Include(t => t.TeamAppUser).Include(t => t.ProfileImage).ToListAsync();
            return View(teams);
        }
        [Title("ویرایش/ افزودن")]
        [Key("b15f51ef-05da-4003-8a43-fbed52f4d9f9")]
        [Icon("fa fa-dashboard")]
        [DontSideBarShow]
        public async Task<IActionResult> EditTeam(short? id)
        {
            var team = id != null ? await _teamService.GetAll().AsNoTracking().Include(t => t.TeamAppUser).Include(t => t.ProfileImage).FirstOrDefaultAsync(t => t.Id == id.Value)
            : new Team();

            return View(team);
        }
        [HttpPost]
        [Title("ویرایش/ افزودن")]
        [Key("b15f51ef-05da-4003-8a43-fbed52f4d9s1")]
        [Icon("fa fa-dashboard")]
        [IgnorePermissionCheck]
        public async Task<IActionResult> EditTeam(Team team)
        {
            if (ModelState.IsValid)
            {
                if (team.Id == 0)
                {
                    var user = _userService.GetAll().AsNoTracking().FirstOrDefault(u => u.Id == team.TeamAppUserId);
                    var result = await _userManager.AddToRoleAsync(user, "Administrator");
                }
                else
                {
                    var baseTeam = await _teamService.GetAll().AsNoTracking().FirstOrDefaultAsync(t => t.Id == team.Id);
                    await _teamService.Update(team);
                    if (team.TeamAppUserId != baseTeam.TeamAppUserId)
                    {
                        var baseuser = _userService.GetAll().AsNoTracking().FirstOrDefault(u => u.Id == baseTeam.TeamAppUserId);
                        await _userManager.RemoveFromRoleAsync(baseuser, "Administrator");
                        var user = _userService.GetAll().AsNoTracking().FirstOrDefault(u => u.Id == team.TeamAppUserId);
                        await _userManager.AddToRoleAsync(user, "Administrator");

                    }


                }
                return RedirectToAction("TeamList");
            }

            return View(team);
        }
        [Title("حذف")]
        [Key("b15f51ef-05da-4003-8a43-fbed52f4d9a4")]
        [Icon("fa fa-dashboard")]
        [DontSideBarShow]
        public async Task<IActionResult> Delete(short id)
        {
            var result = false;
            try
            {
                var team = await _teamService.GetAll().AsNoTracking().FirstOrDefaultAsync(t => t.Id == id);
                var user = _userService.GetAll().AsNoTracking().FirstOrDefault(r => r.Id == team.TeamAppUserId);
                await _teamService.Delete(team);
                var rr = await _userManager.RemoveFromRoleAsync(user, "Administrator");
                result = true;
            }
            catch (System.Exception)
            {

            }
            return new JsonResult(new
            {
                result = result
            });
        }
        [HttpPost]
        [IgnorePermissionCheck]
        public IActionResult ReturnAppUSerList()
        {
            return ViewComponent("SelectUser");
        }

        [HttpPost]
        [IgnorePermissionCheck]
        public IActionResult SHowUserInfoInTeam(string userId)
        {
            return ViewComponent("EditUserInfo", new { userId = userId });
        }

        //  Social Network  

        /// <summary>
        /// حذف شبکه اجتماعی
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        [Title("حذف شبکه اجتماعی")]
        [Key("0bf18d67-d390-4781-a065-d60eec58647f")]
        [Icon("fa fa-dashboard")]
        [DontSideBarShow]
        public async Task<IActionResult> DeleteSocialNetwork(short id)
        {
            var socialNetwork = await _socialNetworkService.GetAll().AsNoTracking().FirstOrDefaultAsync(s => s.Id == id);
            var result = false;
            try
            {
                await _socialNetworkService.Delete(socialNetwork);
                result = true;
            }
            catch { }
            return new JsonResult(new
            {
                result = result
            });
        }
        [HttpPost]
        [Title("ایجاد یا ویرایش شبکه اجتماعی")]
        [Key("4c849fcb-9dff-4f5d-9f1c-d84baa913d84")]
        [Icon("fa fa-dashboard")]
        [DontSideBarShow]
        public IActionResult CreateOrEditSocialNetwork(short id, short? teamId)
        {
            return ViewComponent("CreateSocialNetwork", new { id = id, teamId = teamId });
        }
        [HttpPost]
        [Title("سابمیت فرم ویرایش/ ساخت شبکه اجتماعی")]
        [Key("570886f3-4c31-4290-8d2e-763dac1dc964")]
        [Icon("fa fa-dashboard")]
        [DontSideBarShow]
        public async Task<IActionResult> SubmitCreateOrEditScoialNetworkAsync(short id, short? siteSettingId, short? teamId, string name, string address, string faClass)
        {

            var socialNetwork = new SocialNetwork();
            if (id != 0)
            {
                socialNetwork = await _socialNetworkService.GetAll().FirstOrDefaultAsync(s => s.Id == id);
                socialNetwork.Name = name;
                socialNetwork.Address = address;
                socialNetwork.FaClass = faClass;

                await _socialNetworkService.Update(socialNetwork);


            }
            else if (teamId != null)
            {
                socialNetwork.Name = name;
                socialNetwork.Address = address;
                socialNetwork.FaClass = faClass;
                socialNetwork.TeamId = teamId;

                await _socialNetworkService.Create(socialNetwork);

            }
            else
            {
                siteSettingId = siteSettingId != null ? siteSettingId : _siteSettingService.GetAll().FirstOrDefault().Id;
                socialNetwork.Name = name;
                socialNetwork.Address = address;
                socialNetwork.FaClass = faClass;
                socialNetwork.TeamId = null;
                socialNetwork.SiteSettingId = siteSettingId;

                await _socialNetworkService.Create(socialNetwork);

            }
            return ViewComponent("SocialNetwork", new { teamId = teamId });
        }
        /// <summary>
        /// رفرش ویوکامپوننت 
        /// </summary>
        /// <param name="teamId"></param>
        /// <returns></returns>
        [HttpPost]
        [IgnorePermissionCheck]
        public IActionResult RefreshSocialViewComponent(short? teamId)
        {
            return ViewComponent("SocialNetwork", new { teamId = teamId });
        }
        [HttpPost]
        [IgnorePermissionCheck]
        public async Task<IActionResult> ActiveOrDeActiveSN(short id)
        {
            var result = false;
            try
            {
                var socialNetwork = await _socialNetworkService.GetAll().FirstOrDefaultAsync(s => s.Id == id);
                socialNetwork.IsActive = !socialNetwork.IsActive;
                await _socialNetworkService.Update(socialNetwork);
                result = true;
            }
            catch (System.Exception)
            {
            }
            return new JsonResult(new
            {
                result = result
            });
        }
        #region  MainSlider
        /// <summary>
        /// حذف فایل از اسلادیر
        /// </summary>
        /// <param name="id">اس دی فایل</param>
        /// <returns></returns>
        [HttpPost]
        [IgnorePermissionCheck]
        public async Task<IActionResult> DeleteSliderFile(short id)
        {
            var result = false;
            try
            {
                var file = await _fileService.GetAll().AsNoTracking().FirstOrDefaultAsync(f => f.Id == id);
                file.SliderId = null;
                await _fileService.Update(file);
                result = true;
            }
            catch
            {
            }
            return new JsonResult(new
            {
                result = result
            });
        }
        /// <summary>
        /// رفرش اسلایدر اصلی
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [IgnorePermissionCheck]
        public IActionResult RefreshMainSideBar()
        {
            return ViewComponent("MainSlider");
        }
        /// <summary>
        /// افزودن فایل به اسلایدر
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        [IgnorePermissionCheck]
        public async Task<IActionResult> AddFileToSlider(short id)
        {
            var result = false;
            try
            {
                var slider = await _sliderService.GetAll().AsNoTracking().FirstOrDefaultAsync(s => s.Name == "MainPage");
                var file = await _fileService.GetAll().AsNoTracking().FirstOrDefaultAsync(f => f.Id == id);
                file.SliderId = slider.Id;
                await _fileService.Update(file);
                result = true;
            }
            catch { }
            return new JsonResult(new
            {
                result = result
            });
        }
        #endregion
    }

}