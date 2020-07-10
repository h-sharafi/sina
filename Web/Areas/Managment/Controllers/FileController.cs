using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Application.Errors;
using Application.Service;
using AutoMapper;
using Domain;
using Domain.ViewModels;
using Infrastructure.Attributes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Web.Areas.Managment.Controllers
{
    public class FileController : ApiController
    {
        private readonly IFileService _fileService;
        private readonly IMapper _mapper;

        public FileController(IFileService fileService, IMapper mapper)
        {
            this._mapper = mapper;
            this._fileService = fileService;
        }

        [HttpPost, DisableRequestSizeLimit]
        [Title("آپلود")]
        [Key("867b4783-8c02-4b09-983a-251ee1546633")]
        [Icon("fa fa-dashboard")]
        [DontSideBarShow]
        public async Task<ActionResult<File>> Upload([FromForm] FileViewModel fileVm)
        {
      
            if (fileVm.FormFile.Length == 0) throw new RestException(HttpStatusCode.BadRequest, "لطفا یک فایل انتخاب کنید");
            if (fileVm.FileCategoryId == 0) fileVm.FileCategoryId = null;
            fileVm.Length = fileVm.FormFile.Length;
            fileVm.FileName = await _fileService.Upload(fileVm.FormFile);
            // باید یک ترای کش گذاشته شود و در صورت عدم ذخیره فایل بالا را حذف کند
            try
            {
                var file = _mapper.Map<File>(fileVm);
                return await _fileService.Create(file);
            }
            catch (System.Exception)
            {
                throw new Exception("عدم توانایی در آپلود فایل");
            }


        }

         [HttpPost("ByFilter")]
        [Title("گرفتن لیست کارها با فیلتر ")]
        [Key("6541108f-41b0-458c-8a80-ae01fec4e4fe")]
        [Icon("fa fa-dashboard")]
        [DontSideBarShow]

        public async Task<ActionResult<ReturnFileFilter>> GetByFiltre(FileFilterModelViewModel data)
        {
            var files = _fileService.GetAll().AsNoTracking().AsQueryable();
            FileFilterViewModel filter = data.FileFilter != null ? data.FileFilter : new FileFilterViewModel
            {
                Type = "title",
                IsUp = true
            };

            switch (filter.Type)
            {
                case "title":
                    files = filter.IsUp ? files.OrderBy(f => f.Title) : files.OrderByDescending(f => f.Title);
                    break;
                case "fileName":
                    files = filter.IsUp ? files.OrderBy(f => f.FileName) : files.OrderByDescending(f => f.FileName);
                    break;
                  case "length":
                    files = filter.IsUp ? files.OrderBy(f => f.Length) : files.OrderByDescending(f => f.Length);
                    break;
            }

            var count = await _fileService.GetAll().CountAsync();
            var totlapage = (short)Math.Ceiling(count / (double)data.PageSize);

            var page = data.PageIndex <= totlapage ? data.PageIndex : totlapage;
            files = files.Skip((page > 0 ? page - 1 : 0) * data.PageSize).Take(data.PageSize);

            return new ReturnFileFilter
            {
                Files = await files.ToListAsync(),
                TotlaPage = totlapage,
                TotalCount = count
            };


        }
 
    }

}