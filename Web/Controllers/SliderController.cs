using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class SliderController : BaseController
    {
        public SliderController()
        {

        }
        public IActionResult Index()
        {
            return View();
        }
    }

}