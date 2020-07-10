using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Persistence;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Application.Service
{
    public interface IFileService : IEntityService<Domain.File>
    {
        Task<string> Upload(IFormFile file);
        Task<bool> DeleteFile(short fileId);
        bool DeleteFileByName(string fileName);
    }
    public class FileService : EntityService<Domain.File>, IFileService
    {
        public FileService(DataContext context, IUserAccessor userAccessor) : base(context, userAccessor) { }

        public async Task<bool> DeleteFile(short fileId)
        {
            var folderName = Path.Combine("wwwroot", "UplodedFiles");
            var fileName = await _dbset.FirstOrDefaultAsync(f => f.Id == fileId);
            if (System.IO.File.Exists(Path.Combine(folderName, fileName.Name)))
            {
                // If file found, delete it    
                System.IO.File.Delete(Path.Combine(folderName, fileName.Name));
                return true;
            }
            return false;
        }

        public bool DeleteFileByName(string fileName)
        {
            var folderName = Path.Combine("wwwroot", "UplodedFiles");
            if (System.IO.File.Exists(Path.Combine(folderName, fileName)))
            {
                System.IO.File.Delete(Path.Combine(folderName, fileName));
                return true;
            }
            return false;
        }

        public async Task<string> Upload(IFormFile file)
        {
            if (file == null || file.Length == 0)
                throw new Exception("file is Empty");

            return await SaveFile(file);



        }

        private bool GetFileTypeName(string path, string fileType)
        {
            var ext = Path.GetExtension(path)?.ToLowerInvariant();
            return ext == fileType.ToLower();

        }
        private async Task<string> SaveFile(IFormFile file)
        {
            if (file == null) return null;
            var folderName = Path.Combine("wwwroot", "UplodedFiles");
            var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);

            var FileGuidName = Guid.NewGuid().ToString();
            var FileName = FileGuidName + Path.GetExtension(file.FileName);
            string fullPath = Path.Combine(pathToSave, FileName);

            await using (var stream = new FileStream(fullPath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            return FileName;

        }
    }
}