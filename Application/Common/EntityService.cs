using Application.Errors;
using Application.Service;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Threading.Tasks;


namespace Application
{
    public abstract class EntityService<T> : IEntityService<T> where T : class
    {
        protected readonly DataContext _context;
        protected readonly DbSet<T> _dbset;
        private readonly IUserAccessor _userAccessor;
        public EntityService(DataContext context, IUserAccessor userAccessor)
        {
            _context = context;
            _dbset = _context.Set<T>();
            this._userAccessor = userAccessor;
        }

        public async Task AddRange(List<T> entities)
        {
            await _dbset.AddRangeAsync(entities);
        }

        public async Task<T> Create(T entity)
        {

            CheckNull(entity);
            var curentUserId = _userAccessor.GetCurrentUserId();
            PropertyInfo fieldPropertInfo = entity.GetType().GetProperties().FirstOrDefault(p => p.Name == "CreationTime");
            if (fieldPropertInfo != null) fieldPropertInfo.SetValue(entity, DateTime.Now);


            PropertyInfo CreationUserId = entity.GetType().GetProperties().FirstOrDefault(p => p.Name == "CreationUserId");
            if (CreationUserId != null) CreationUserId.SetValue(entity, curentUserId);

            try
            {
                _dbset.Add(entity);
                await _context.SaveChangesAsync();
                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + ex.InnerException);
            }
        }

        public async Task<bool> Delete(short id)
        {
            T entity = await GetById(id);
            CheckNull(entity);
            try
            {
                _dbset.Remove(entity);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return true;
        }

        public async Task<bool> DeleteAllAsync()
        {
            try
            {
                var entityList = await _dbset.ToListAsync();
                foreach (var entity in entityList)
                {
                    _dbset.Remove(entity);
                }
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new RestException(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        public async Task<bool> DeleteByEntoty(T entity)
        {
            CheckNull(entity);
            try
            {
                _dbset.Remove(entity);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return true;
        }

        public IQueryable<T> GetAll()
        {

            return _dbset;
        }


        public List<T> GetList()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Update(T entity)
        {
            CheckNull(entity);
            try
            {
                var curentUserId = _userAccessor.GetCurrentUserId();
                // افزودن آخرین تاریخ ویرایش
                //PropertyInfo fieldPropertInfo = entity.GetType().GetProperties().FirstOrDefault(p => p.Name == "LastModificationDate");
                //if (fieldPropertInfo != null) fieldPropertInfo.SetValue(entity, DateTime.Now, null);

                //PropertyInfo ModificationUser = entity.GetType().GetProperties().FirstOrDefault(p => p.Name == "ModifiedUser");
                //if (ModificationUser != null)
                //{
                //    var user = _context.Set<AppUser>().Find(curentUserId);
                //    var modifierList = new List<AppUser>();
                //    var lastUsers = ModificationUser.GetValue(entity);
                //    var type = lastUsers;
                //    var kkkk = lastUsers.ToString();
                //    //if (lastUsers != null) modifierList = lastUsers ;
                //    //lastUsers.Add(user);
                //    ModificationUser.SetValue(entity, modifierList, null);
                //}
                //_context.Entry(entity).State = EntityState.Modified;
                _context.Entry(entity).Property("CreationTime").IsModified = false;
                //_context.Entry(entity).Property("CreationUserId").IsModified = false;
                //_context.entry(entity).property("creationtime").ismodified = false;

                //_context.Entry(entity).State = EntityState.Modified;
                _dbset.Update(entity);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new RestException(HttpStatusCode.BadRequest, ex.Message);
            }

            return true;
        }
        private void CheckNull(T entity)
        {
            if (entity == null) throw new RestException(HttpStatusCode.BadRequest, "content not found");
        }

        public async Task<T> GetById(long id)
        {
            var entity = await _dbset.FindAsync(id);
            CheckNull(entity);
            return entity;
        }

        public async Task<bool> Delete(T entity)
        {
            CheckNull(entity);
            try
            {
                _dbset.Remove(entity);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return true;
        }
    }
}
