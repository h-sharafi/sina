using System;
using System.Net;
using System.Threading.Tasks;
using Application.Errors;
using Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Service
{
    public interface IUploadInfoService : IEntityService<UploadInfo>
    {
        Task PlusUploadInfo(short fileId);
    }
    public class UploadInfoService : EntityService<UploadInfo>, IUploadInfoService
    {
        private readonly IUserService _userService;

        public UploadInfoService(DataContext context, IUserAccessor userAccessor, IUserService userService) : base(context, userAccessor)
        {
            this._userService = userService;
        }
     /// <summary>
     /// 
     /// </summary>
     /// <param name="id"></param>
     /// <param name="fileId">ای دی فایل</param>
     /// <returns></returns>
        public async Task PlusUploadInfo(short fileId)
        {
            try
            {
                var file = await _context.Files.FirstOrDefaultAsync(f => f.Id == fileId);
                if (file == null) throw new RestException(HttpStatusCode.NotFound);
                var uploadInfoModel = await _dbset.FirstOrDefaultAsync();
                if (uploadInfoModel != null)
                {
                    uploadInfoModel.FileId = fileId;
                    uploadInfoModel.CreationTime = DateTime.Now;
                    uploadInfoModel.UserId = await _userService.CurentUserId();
                    uploadInfoModel.TotalUploads += 1;

                    await Update(uploadInfoModel);

                }
                else
                {
                    await Create(new UploadInfo
                    {
                        FileId = fileId,
                        CreationTime = DateTime.Now,
                        UserId = await _userService.CurentUserId(),
                        TotalUploads = 1
                    });
                }
            }
            catch (System.Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
    }
}