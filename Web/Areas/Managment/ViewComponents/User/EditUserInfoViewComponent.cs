using Application.Service;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.Managment.ViewComponents.User
{
    public class EditUserInfoViewComponent : ViewComponent
    {
        private readonly IUserService _userService;

        public EditUserInfoViewComponent(IUserService userService)
        {
            this._userService = userService;
        }
        public async Task<IViewComponentResult> InvokeAsync(string userId)
        {
            AppUser appUser = null;
            if (userId != null)
                appUser = await _userService.GetAll().AsNoTracking().FirstOrDefaultAsync(u => u.Id == userId);
            return View(appUser);
        }
    }
}
