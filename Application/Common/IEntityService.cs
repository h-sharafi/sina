
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application;

namespace Application
{

    public interface IEntityService<T> : IService where T : class
    {
        Task<T> Create(T entity);
        Task<bool> Delete(short id);
        Task<bool> DeleteByEntoty(T entity);
        Task<bool> Update(T entity);
        IQueryable<T> GetAll();
        List<T> GetList();
        Task<T> GetById(long id);
        Task<bool> DeleteAllAsync();
        Task AddRange(List<T> entities);
        Task<bool> Delete(T entity);
    }
}
