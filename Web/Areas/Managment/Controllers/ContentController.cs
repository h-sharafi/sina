using Application.Service;
using Domain;
using Infrastructure.Attributes;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using VestaEShop.Web.Areas.Management.Controllers;

namespace Web.Areas.Managment.Controllers
{
    [Title("محتواها")]
    [Key("000783a6-f8e1-4868-be61-aaebb5c2ba5c")]
    [Icon("fa fa-dashboard")]
    public class ContentController : ManagementController
    {
        private readonly IContentService _contentService;
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly IContentTypeService _contentTypeService;

        public ContentController(IContentService contentService, IWebHostEnvironment hostingEnvironment, IContentTypeService contentTypeService)
        {
            this._contentTypeService = contentTypeService;
            this._contentService = contentService;
            this._hostingEnvironment = hostingEnvironment;
        }
        [Title("ایندکس")]
        [Key("852491c8-f553-473b-8008-f1eb2ce98afd")]
        [Icon("fa fa-dashboard")]
        public async Task<IActionResult> Index()
        {
            var model = await _contentService.GetAll().ToListAsync();
            return View(model);
        }
        [Title("ساخت")]
        [Key("9304df09-fe81-4391-a1ef-49155c8f20b2")]
        [Icon("fa fa-dashboard")]
        public async Task<IActionResult> Create(short id = 0)
        {
            var content = id == 0 ? new Content() :
             await _contentService.GetAll().AsNoTracking().Include(c => c.CoverImage).Include(c=>c.ProfileImage).FirstOrDefaultAsync(c => c.Id == id);
            return View(content);
        }

        [HttpPost]
        [Title("ساخت")]
        [Key("394fe542-4db0-46e7-bdf2-d12c3b956dbb")]
        [Icon("fa fa-dashboard")]
        public async Task<IActionResult> Create(Content content)
        {
            if (content.ContentTypeId == 0) throw new Exception("نوع محتوا مشخص نیست ");
            if (ModelState.IsValid)
            {
                if (content.Id == 0)
                {
                    await _contentService.Create(content);
                    Success("محتوا با موفقیت افزوده شد ", true);
                }
                else
                {
                    var baseContent =await _contentService.GetAll().AsNoTracking().FirstOrDefaultAsync(c => c.Id == content.Id);
                    baseContent.Keywords = content.Keywords;
                    baseContent.Name = content.Name;
                    baseContent.ContentTypeId = content.ContentTypeId;
                    baseContent.CoverImageId = content.CoverImageId;
                    baseContent.ProfileImageId = content.ProfileImageId;
                    baseContent.Description = content.Description;
                    baseContent.Title = content.Description;
                    baseContent.Text = content.Text;

                    await _contentService.Update(baseContent);
                    Success("محتوا با موفقیت ویرایش شد ", true);
                }
                return RedirectToAction("Index", "Content");
            }
            return View(content);
        }

        [HttpPost]
        [Title("اپلود-ادیتور")]
        [Key("a99f4a60-e1d3-4a92-9591-51c36f6eff6a")]
        [Icon("fa fa-dashboard")]
        [DontSideBarShow]
        // [ValidateAntiForgeryToken]
        public IActionResult UploadImage(IFormFile upload, string CKEditorFuncNum, string CKEditor, string langCode)
        {
            if (upload.Length <= 0) return null;
            var fileName = Guid.NewGuid() + Path.GetExtension(upload.FileName).ToLower();
            var path = Path.Combine(
                _hostingEnvironment.WebRootPath, "UplodedFiles",
                fileName);
            using (var stream = new FileStream(path, FileMode.Create))
            {
                upload.CopyTo(stream);

            }
            var url = $"{"/UplodedFiles/"}{fileName}";
            return Json(new { uploaded = true, url });
        }
        [Title("نوع محتوا")]
        [Key("7cca8512-d3bb-4ad4-96db-fe7a8cce5b74")]
        [Icon("fa fa-dashboard")]
        public async Task<IActionResult> ContentType()
        {
            var contentTypes = await _contentTypeService.GetAll().ToListAsync();
            return View(contentTypes);
        }

        [HttpPost]
        [Title("افزودن محتوا")]
        [Key("29ed1505-e959-44ad-a052-a481fd9e893a")]
        [Icon("fa fa-dashboard")]
        [DontSideBarShow]
        public async Task<IActionResult> AddConetntType(string name, bool isMainPage)
        {
            if (!String.IsNullOrEmpty(name))
                await _contentTypeService.Create(new ContentType { Name = name, IsMainPage = isMainPage, IsActive = false });
            short id = 0;
            return ViewComponent("ContentType", new { selectedContentType = id });

        }
        [HttpPost]
        [IgnorePermissionCheck]
        public IActionResult SetActiveContentType(short id)
        {
            return ViewComponent("ContentType", new { selectedContentType = id });
        }
        [HttpPost]
        [IgnorePermissionCheck]
        public IActionResult CreateContentTypePartial()
        {
            return PartialView("_CreateContentType");
        }
        [HttpPost]
        [Title("فعال /غیره فعال")]
        [Key("5ac23b28-6778-40ee-8d42-697977d0ae09")]
        [Icon("fa fa-dashboard")]
        [DontSideBarShow]
        public async Task<JsonResult> ChangeContentActicve(short id)
        {
            var content = await _contentService.GetAll().FirstOrDefaultAsync(c => c.Id == id);
            content.IsActive = !content.IsActive;
            await _contentService.Update(content);
            return new JsonResult(new
            {
                result = content.IsActive
            });
        }
        [HttpPost]
        [Title("حذف")]
        [Key("70b892c5-f8be-42dc-b8aa-42494369362e")]
        [Icon("fa fa-dashboard")]
        [DontSideBarShow]

        public async Task<JsonResult> Delete(short id)
        {
            try
            {
                var content = await _contentService.GetAll().FirstOrDefaultAsync(c => c.Id == id);
                await _contentService.Delete(content);
                return new JsonResult(new
                {
                    result = true
                });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPost]
        [Title("فعال/ غیره فعال نوع محتوا")]
        [Key("a1f6f995-c107-4f6a-b615-ae88d915044a")]
        [Icon("fa fa-dashboard")]
        [DontSideBarShow]
        public async Task<JsonResult> ChangeContentTypeActive(short id)
        {
            var contentType = await _contentTypeService.GetAll().AsNoTracking().FirstOrDefaultAsync(ct => ct.Id == id);
            var result = false;
            var text = string.Empty;
            if (contentType != null)
            {
                try
                {
                    contentType.IsActive = !contentType.IsActive;
                    await _contentTypeService.Update(contentType);
                    text = "عملیات با موفقیت انجام شد";
                    result = true;
                }
                catch (System.Exception)
                {
                    text = "خطا در ویرایش کانت تایپ";
                }
            }
            else
            {
                text = "نوع محتوا یافت نشد";
            }

            return new JsonResult(new
            {
                text = text,
                result = result,
                isActive = contentType.IsActive
            });
        }
        [HttpPost]
        [IgnorePermissionCheck]
        public IActionResult ShowCreateContentCover(Domain.File file, short fileId)
        {
            return ViewComponent("ShowContentCoverImage", new { file = file.Id != 0 ? file : null, fileId = fileId });
        }
    }
}