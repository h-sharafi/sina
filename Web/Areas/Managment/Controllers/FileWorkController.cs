using System.Threading.Tasks;
using Application.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Domain;
using Microsoft.AspNetCore.Server.IIS.Core;
using System;
using Domain.ViewModels;
using Application.Errors;
using System.Net;
using Infrastructure.Attributes;
using Infrastructure.EM;
using AutoMapper;
using VestaEShop.Web.Areas.Management.Controllers;

namespace Web.Areas.Managment.Controllers
{
    [Title("فایل")]
    [Key("e4474e9c-0120-452c-be6e-d8d0ca5a8c6b")]
    [Icon("fa fa-dashboard")]
    public class FileWorkController : ManagementController
    {
        private readonly IFileService _fileService;
        private readonly IFileCategoryService _fileCategoryService;
        private readonly IMapper _mapper;
        private readonly IUploadInfoService _uploadInfoService;
        public FileWorkController(IFileService fileService, IFileCategoryService fileCategoryService, IMapper mapper, IUploadInfoService uploadInfoService)
        {
            this._uploadInfoService = uploadInfoService;
            this._mapper = mapper;
            this._fileCategoryService = fileCategoryService;
            this._fileService = fileService;

        }
        [Title("فایل")]
        [Key("da8448ce-bea5-4b3f-a1d7-75dcdab0110e")]
        [Icon("fa fa-dashboard")]
        public IActionResult Index()
        {
            return View();
        }
        [Title("دسته بندی")]
        [Key("e2ffda8b-02f1-4541-a776-8b567a51dd0cF")]
        [Icon("fa fa-dashboard")]
        public async Task<IActionResult> FileCategory()
        {
            var fileCategoryes = _fileCategoryService.GetAll().Include(m => m.Parent).Include(m => m.Children).ThenInclude(fc => fc.Children).ThenInclude(fc => fc.Children).ThenInclude(fc => fc.Children).ThenInclude(fc => fc.Children).AsNoTracking();
            return View(await fileCategoryes.Where(m => m.Parent == null).ToListAsync());
        }
        [HttpPost]
        [Title(" VC افزودن")]
        [Key("a619f64d-b4d2-4ec1-b4d1-f445d70db1cb")]
        [Icon("fa fa-dashboard")]
        [DontSideBarShow]
        public IActionResult AddFileCategoryVC(short parentId)
        {
            return ViewComponent("AddFileCategory", new { id = parentId });
        }
        [HttpPost]
        [Title("افزودن")]
        [Key("9841e734-f789-4676-b674-70bc8d91c769")]
        [Icon("fa fa-dashboard")]
        [DontSideBarShow]
        public async Task<JsonResult> AddFileCategory(FileCategory fileCategory)
        {
            if (String.IsNullOrEmpty(fileCategory.Name))
                return new JsonResult(new { result = false });
            try
            {
                if (fileCategory.ParentId == 0) fileCategory.ParentId = null;

                if (fileCategory.Id != 0) await _fileCategoryService.Update(fileCategory);
                else await _fileCategoryService.Create(fileCategory);
                return new JsonResult(new
                {
                    result = true
                });
            }
            catch (System.Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// نوسازی دسته بندی فایل ها
        /// </summary>
        /// <returns></returns>
        [Title("نوسازی")]
        [Key("eaf26c22-c7c8-4777-a620-28caeb7a3604")]
        [Icon("fa fa-dashboard")]
        [DontSideBarShow]
        public async Task<IActionResult> RefreshFc()
        {
            var fileCategoryes = await _fileCategoryService.GetAll().Where(fc => fc.ParentId == null).Include(m => m.Parent).Include(m => m.Children).ThenInclude(fc => fc.Children).ThenInclude(fc => fc.Children).ThenInclude(fc => fc.Children).ThenInclude(fc => fc.Children).AsNoTracking().ToListAsync();
            return ViewComponent("FileCategory", fileCategoryes);
        }

        // FileUpload
        [Title("آپلود")]
        [Key("712d6d77-9db6-4817-83ff-2afee7acfcf9")]
        [Icon("fa fa-dashboard")]
        public IActionResult FileUpload()
        {
            return View();
        }
        [HttpPost]
        [Title("آپلود")]
        [Key("867b4783-8c02-4b09-983a-251ee1546633")]
        [Icon("fa fa-dashboard")]
        [DontSideBarShow]
        public async Task<IActionResult> FileUpload([FromForm] FileViewModel fileVm)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (fileVm.FormFile.Length == 0) throw new RestException(HttpStatusCode.BadRequest, "لطفا یک فایل انتخاب کنید");
                    if (fileVm.FileCategoryId == 0) fileVm.FileCategoryId = null;
                    fileVm.Length = fileVm.FormFile.Length;
                    fileVm.FileName = await _fileService.Upload(fileVm.FormFile);
                    var file = _mapper.Map<File>(fileVm);
                    file.FileType = fileVm.FormFile.ContentType;
                    await _fileService.Create(file);
                    await _uploadInfoService.PlusUploadInfo(file.Id);
                    Success("آپلود فایل با موفقیت انجام شد", true);
                    return RedirectToAction("Index");
                }
                catch (System.Exception)
                {
                    if (fileVm.FileName != null)
                    {
                        _fileService.DeleteFileByName(fileVm.FileName);
                    }
                    throw new Exception("عدم توانایی در آپلود فایل");
                }


            }
            return View(fileVm);

        }
        [Title("فایل ها")]
        [Key("e974699a-f443-42fd-b98f-dc69189100bb")]
        [Icon("fa fa-dashboard")]
        [DontSideBarShow]
        public IActionResult Files(pagginViewModel pagging)
        {
            return View(pagging);
        }

        [HttpPost]
        [Title("گرفتن فایل ها-ایجکس")]
        [Key("ec320d05-f466-451c-a134-9640543a8c86")]
        [Icon("fa fa-dashboard")]
        [DontSideBarShow]
        public IActionResult GetFile(int pageIndex, int pageSize, short? fileCategoryId, string fileType)
        {
            return ViewComponent("FileShow", new { pageIndex = pageIndex, pageSize = pageSize, fileCategoryId = fileCategoryId, fileType = fileType });
        }
        [HttpPost]
        [Title("حذف دسته بندی ها")]
        [Key("19c170c1-520d-4590-8686-7f0df2303324")]
        [Icon("fa fa-dashboard")]
        [DontSideBarShow]
        public async Task<IActionResult> DeleteFileCategory(short id)
        {
            var fileCategory = await _fileCategoryService.GetAll().AsNoTracking().FirstOrDefaultAsync(fc => fc.Id == id);
            try
            {
                await _fileCategoryService.Delete(fileCategory);
                return new JsonResult(new
                {
                    result = true, 
                    text = "حذف با موفقیت انجام شد"
                });
            }
            catch (System.Exception)
            {
                                return new JsonResult(new
                {
                    result = false, 
                    text = "خطایی رخ داده است"
                });
            }
        }

    }

}
