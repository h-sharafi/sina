using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Service;
using Microsoft.EntityFrameworkCore;

namespace Web.ViewComponents
{
    public class ContentDetailsSocialNetworkViewComponent : ViewComponent
    {
        private readonly ITeamService _teamService;

        public ContentDetailsSocialNetworkViewComponent(ITeamService teamService)
        {
            this._teamService = teamService;
        }
        public async Task<IViewComponentResult> InvokeAsync(short teamId)
        {
            var socialNetwork = await _teamService.GetAll().AsNoTracking().Include(s => s.SocialNetworks).FirstOrDefaultAsync(t => t.Id == teamId);
            return View(socialNetwork);
        }
    }
}
