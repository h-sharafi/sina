using System.Linq;
using System.Threading.Tasks;
using Application.Service;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Web.Areas.Managment.ViewComponents
{
    public class NavbarViewComponent : ViewComponent
    {
        private readonly ICommentService _commentService;

        public NavbarViewComponent(ICommentService commentService)
        {
            this._commentService = commentService;


        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = new NavbarViewModel
            {
                Comments = await _commentService.GetAll().AsNoTracking().Where(c => !c.IsRead).Select(cmt => new NavbarCommentViewModel
                {
                    Id = cmt.Id,
                    Name = $"{cmt.Name} ${cmt.Name} ",
                    Text = cmt.Text.Length > 20 ? cmt.Text.Substring(0, 20) : cmt.Text,
                    DateTime = cmt.CreationTime.ToPersianDigitalDateTimeString()
                }).ToListAsync()
            };
            return View(model);
        }
    }
}