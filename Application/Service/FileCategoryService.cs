using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.EntityFrameworkCore;
using Persistence;
using Microsoft.AspNetCore.Identity;

namespace Application.Service
{
    public interface IFileCategoryService : IEntityService<FileCategory>
    {
        Task<Dictionary<short, string>> GetDictionaryAsync();
    }
    public class FileCategoryService : EntityService<FileCategory>, IFileCategoryService
    {
        public FileCategoryService(DataContext context, IUserAccessor userAccessor) : base(context, userAccessor)
        {
        }

        public async Task<Dictionary<short, string>> GetDictionaryAsync()
        {
            var result = new Dictionary<short, string>();
            var models = await _dbset.Include(fc => fc.Parent).AsNoTracking().ToListAsync();
            models.ForEach(fc =>
            {
                result.Add(fc.Id, fc.Name);
            });
            return result;
        }
    }
}