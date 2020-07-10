using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace Application.Service
{
    public interface IUserAccessor
    {
        string GetCurrentUsername();
        string GetCurrentUserId();
    }

    public class UserAccessor : IUserAccessor
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<AppUser> _userManager;

        public UserAccessor(IHttpContextAccessor httpContextAccessor, UserManager<AppUser> userManager)
        {
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
        }

        public string GetCurrentUserId()
        {
            //var claims = _httpContextAccessor.HttpContext.User?.Claims;
            //var claim = _httpContextAccessor.HttpContext.User?.Claims?.FirstOrDefault(x => x.Type == ClaimTypes.Sid);
            //var userId = _httpContextAccessor.HttpContext.User?.Claims?.FirstOrDefault(x => x.Type == ClaimTypes.Sid)?.Value;
            //var userId = _userManager.Users.FirstOrDefault(u => u.UserName == GetCurrentUsername())?.Id ?? null;
            //return userId;
            return GetCurrentUsername();

        }

        public string GetCurrentUsername()
        {
            var username = _httpContextAccessor.HttpContext.User?.Claims?.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;

            return username;
        }

    }
}
