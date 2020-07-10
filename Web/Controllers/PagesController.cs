using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class PagesController : BaseController
    {
        public PagesController()
        {

        }
        public IActionResult AboutUs()
        {
            return View();
        }
    }
}