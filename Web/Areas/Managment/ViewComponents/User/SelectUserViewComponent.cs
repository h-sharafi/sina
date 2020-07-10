using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Service;
using Infrastructure.EM;
using Microsoft.EntityFrameworkCore;

namespace Web.Areas.Managment.ViewComponents
{
    public class SelectUserViewComponent:ViewComponent
    {
        private readonly IUserService _userService;

        public SelectUserViewComponent(IUserService userService)
        {
            this._userService = userService;
        }
        public async Task<IViewComponentResult> InvokeAsync(string search , int pageIndex, int pageSize)
        {
            var model = _userService.GetAll();
            model = search != null ? model.Where(file => file.Email.Contains(search)) : model;
           
            var retungPagingViewModel = model.Paging(pageIndex, pageSize);
            var modelResult = await retungPagingViewModel.RetunIQueryableModel.AsNoTracking().ToListAsync();

            return View(modelResult);
        }
    }
}
