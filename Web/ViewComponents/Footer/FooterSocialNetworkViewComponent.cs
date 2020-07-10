using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Service;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using Infrastructure.EM;
using Domain;

namespace Web.ViewComponents.Footer
{
    public class FooterSocialNetworkViewComponent: ViewComponent
    {
        private readonly ISocialNetworkService _socialNetworkService;

        public FooterSocialNetworkViewComponent(ISocialNetworkService socialNetworkService)
        {
            this._socialNetworkService = socialNetworkService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var socialNetwork =await _socialNetworkService.GetAll().AsNoTracking().Where(c => c.TeamId == null).ToListAsync();
            return View(socialNetwork);
        }
    }
}
