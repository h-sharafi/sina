using System;
using System.Threading.Tasks;
using Application.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Domain;
using System.Collections.Generic;
using VestaEShop.Web.Areas.Management.Controllers;
using Infrastructure.Attributes;
using System.Linq;

namespace Web.Areas.Managment.Controllers
{
    [Title("کامپوننت ها")]
    [Key("9fc08eea-1833-491b-85bd-fd45cdcb188c")]
    [Icon("fa fa-dashboard")]
    public class ComponentController : ManagementController
    {
        private readonly IAudioCmsService _audioCmsService;
        private readonly ISliderService _sliderService;
        private readonly ISliderTypeService _sliderTypeService;
        private readonly IFileService _fileService;
        private readonly IImageCmsService _imageCmsService;
        private readonly IImageCmsTypeService _imageCmsTypeService;
        public ComponentController(IAudioCmsService audioCmsService, ISliderService sliderService, ISliderTypeService sliderTypeService, IFileService fileService, IImageCmsService imageCmsService, IImageCmsTypeService imageCmsTypeService)
        {
            this._imageCmsTypeService = imageCmsTypeService;
            this._imageCmsService = imageCmsService;
            this._fileService = fileService;
            this._sliderTypeService = sliderTypeService;
            this._sliderService = sliderService;
            this._audioCmsService = audioCmsService;
        }

        [Title("ایندکس")]
        [Key("b34f03d0-154d-46e5-94cc-a8d23ad318e4")]
        [Icon("fa fa-dashboard")]
        public async Task<IActionResult> Index()
        {
            var audioCmsList = await _audioCmsService.GetAll().ToListAsync();
            var sliderList = await _sliderService.GetAll().ToListAsync();
            var imageList = await _imageCmsService.GetAll().AsNoTracking().ToListAsync();
            var model = new Tuple<List<AudioCms>, List<Slider>, List<ImageCms>>(audioCmsList, sliderList, imageList);
            return View(model);
        }
        #region  فایل صوتی
        [Title("لیست cms صوتی")]
        [Key("b4723ca7-70aa-477c-9b3b-bh0d1dc828a0")]
        [Icon("fa fa-dashboard")]
        [DontSideBarShow]
        public async Task<IActionResult> AudioCmsList(string fileType = "audio")
        {
            var model = _audioCmsService.GetAll();
            model = fileType != null ? model.Include(c => c.File).Where(acms => acms.File.FileType.Contains(fileType)) : model;
            return View(await model.ToListAsync());
        }

        [Title("ساخت فایل صوتی")]
        [Key("738db72a-8e1c-4e07-a0d6-7c84ac2422c9")]
        [Icon("fa fa-dashboard")]
        [DontSideBarShow]
        public async Task<IActionResult> CreateAudioCms(short id = 0)
        {
            var audioCms = new AudioCms();
            if (id != 0)
                audioCms = await _audioCmsService.GetAll().AsNoTracking().Include(f => f.File).FirstOrDefaultAsync(a => a.Id == id);
            return View(audioCms);
        }

        [HttpPost]
        [Title("ساخت فایل صوتی پست")]
        [Key("350229f2-9d34-4105-92f2-de0cc90ed443")]
        [Icon("fa fa-dashboard")]
        [DontSideBarShow]
        public async Task<IActionResult> CreateAudioCms(AudioCms audioCms)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (audioCms.Id == 0) await _audioCmsService.Create(audioCms);
                    else await _audioCmsService.Update(audioCms);
                    return RedirectToAction("CreateAudioCms", new
                    {
                        id = audioCms.Id
                    });

                }
                catch (Exception ex)
                {

                    throw new Exception(ex.Message);
                }

            }
            return View(audioCms);
        }
        [HttpPost]
        [Title("حذف فایل صوتی")]
        [Key("37c543c2-7980-4010-ad5a-a9235f664eb9")]
        [Icon("fa fa-dashboard")]
        [DontSideBarShow]
        public async Task<IActionResult> DeleteAudioCms(short id)
        {
            var result = false;
            try
            {
                var audiocms = await _audioCmsService.GetAll().FirstOrDefaultAsync(a => a.Id == id);
                await _audioCmsService.Delete(audiocms);
                result = true;
            }
            catch (System.Exception ex)
            {
                var exm = ex.Message;
            }
            return new JsonResult(new
            {
                result = result
            });
        }
        #endregion
        #region تصویر

        [Title("لیست cms اسلایدر")]
        [Key("e303b671-b0ae-457c-aef5-070d4bfd7daa")]
        [Icon("fa fa-dashboard")]
        [DontSideBarShow]
        public async Task<IActionResult> ImageCmsList(string fileType = "image")
        {
            var model = _imageCmsService.GetAll();
            model = fileType != null ? model.Include(c => c.File).Where(acms => acms.File.FileType.Contains(fileType)) : model;
            return View(await model.ToListAsync());
        }

        [HttpPost]
        [Title("حذف فایل تصویری")]
        [Key("749dc3be-03d9-4961-bb2f-4132f79d9a68")]
        [Icon("fa fa-dashboard")]
        [DontSideBarShow]
        public async Task<IActionResult> DeleteImageCms(short id)
        {
            var result = false;
            try
            {
                var imagecms = await _imageCmsService.GetAll().FirstOrDefaultAsync(a => a.Id == id);
                await _imageCmsService.Delete(imagecms);
                result = true;
            }
            catch (System.Exception ex)
            {
                var exm = ex.Message;
                result = false;
            }
            return new JsonResult(new
            {
                result = result
            });
        }

        [Title("ساخت فایل تصویری")]
        [Key("ce99c34f-5890-497e-b431-fe795088939c")]
        [Icon("fa fa-dashboard")]
        [DontSideBarShow]
        public async Task<IActionResult> CreateImageCms(short id = 0)
        {
            var imageCms = new ImageCms();
            if (id != 0)
                imageCms = await _imageCmsService.GetAll().AsNoTracking().Include(f => f.File).FirstOrDefaultAsync(a => a.Id == id);
            return View(imageCms);
        }

        [HttpPost]
        [Title("ساخت فایل صوتی تصویری")]
        [Key("d9829379-e3d4-4d40-ad84-4bc0b5205375")]
        [Icon("fa fa-dashboard")]
        [DontSideBarShow]
        public async Task<IActionResult> CreateImageCms(ImageCms imageCms)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (imageCms.Id == 0) await _imageCmsService.Create(imageCms);
                    else await _imageCmsService.Update(imageCms);
                    return RedirectToAction("CreateImageCms", new
                    {
                        id = imageCms.Id
                    });

                }
                catch (Exception ex)
                {

                    throw new Exception(ex.Message);
                }

            }
            return View(imageCms);
        }

        #endregion تصویر


        [HttpPost]
        [Title("گرفتن فایل")]
        [Key("6623799f-215b-42d5-bf49-3ca7327bb0e0")]
        [Icon("fa fa-dashboard")]
        [DontSideBarShow]
        public IActionResult GetFile(int pageIndex, int pageSize, short? fileCategoryId, string fileType, string selectFileClass = null)
        {
            return ViewComponent("ComponentFileShow", new { pageIndex = pageIndex, pageSize = pageSize, fileCategoryId = fileCategoryId, fileType = fileType, selectFileClass = selectFileClass });
        }

        [HttpPost]
        [Title("گرفتن فایل")]
        [Key("af500d38-05ee-4002-bbd1-a23f385162ba")]
        [Icon("fa fa-dashboard")]
        [IgnorePermissionCheck]
        public IActionResult AudioComponentShow(short fileId)
        {
            return ViewComponent("AudioComponent", new { fileId = fileId });
        }

        [HttpPost]
        [Title("گرفتن فایل")]
        [Key("f0a6747c-c993-45b1-bb42-3e96149e94b7")]
        [Icon("fa fa-dashboard")]
        [IgnorePermissionCheck]
        public IActionResult ImageComponentShow(short fileId)
        {
            return ViewComponent("ImageComponent", new { fileId = fileId });
        }
        // Craete Slider 

        //create Slider Type

    }
}