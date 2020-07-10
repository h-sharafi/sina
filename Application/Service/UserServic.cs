using Domain;
using Domain.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service
{
    public interface IUserService : IEntityService<AppUser>
    {
        Task<bool> Login(LoginViewModel model);
        Task<AppUser> Register(AppUser appUser);
        Task<string> CurentUserId();
        Task<IEnumerable<AppUser>> AllUsers();
        Task<AppUser> GetUserById(string Id);
        Task<AppUser> GetCurentUser();


    }
    public class UserService : EntityService<AppUser>, IUserService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserService(DataContext context, UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager, IHttpContextAccessor httpContextAccessor, IUserAccessor userAccessor): base(context, userAccessor)
        {

            _userManager = userManager;
            _signInManager = signInManager;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<IEnumerable<AppUser>> AllUsers()
        {
            return await _userManager.Users.ToListAsync();
        }

        public async Task<string> CurentUserId()
        {
            var user = await _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User);
            return user?.Id;
        }

        public async Task<AppUser> GetCurentUser()
        {
            return await _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User);
        }

        public async Task<AppUser> GetUserById(string Id)
        {
            var user = await _userManager.Users.AsNoTracking().Where(u => u.Id == Id).FirstOrDefaultAsync();
            return user;
        }

        public async Task<bool> Login(string selectorId)
        {
            var user = await _userManager.FindByNameAsync(selectorId.ToString());
            await _signInManager.SignInAsync(user, isPersistent: false);

            return true;
        }

        public Task<bool> Login(LoginViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task<AppUser> Register(AppUser appUser)
        {
            throw new NotImplementedException();
        }


    }
}
