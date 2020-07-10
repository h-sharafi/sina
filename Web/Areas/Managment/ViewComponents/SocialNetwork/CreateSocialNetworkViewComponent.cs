using Microsoft.AspNetCore.Mvc;
using Domain;
using Application.Service;
using Microsoft.EntityFrameworkCore;

namespace Web.Areas.Managment.ViewComponents
{
    public class CreateSocialNetworkViewComponent : ViewComponent
    {
        private readonly ISocialNetworkService _socialNetworkService;
        public CreateSocialNetworkViewComponent(ISocialNetworkService socialNetworkService)
        {
            this._socialNetworkService = socialNetworkService;

        }
        public async System.Threading.Tasks.Task<IViewComponentResult> InvokeAsync(short? teamId, short id)
        {
            var socialNetwork = new SocialNetwork();
            if (id != 0) socialNetwork = await _socialNetworkService.GetAll().AsNoTracking().FirstOrDefaultAsync(u => u.Id == id);
            else if (teamId != null)
                socialNetwork.TeamId = teamId;
            return View(socialNetwork);
        }
    }
}