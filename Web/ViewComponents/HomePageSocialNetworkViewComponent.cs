using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Application.Service;
using Microsoft.EntityFrameworkCore;

namespace Web.ViewComponents
{
    public class HomePageSocialNetworkViewComponent: ViewComponent
    {
        private readonly ISocialNetworkService _socialNetworkService;

        public HomePageSocialNetworkViewComponent(ISocialNetworkService socialNetworkService)
        {
            this._socialNetworkService = socialNetworkService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var socialNetworks = await _socialNetworkService.GetAll().AsNoTracking().Where(c => c.TeamId == null).ToListAsync();
            return View(socialNetworks);
        }
    }
}
