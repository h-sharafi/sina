using Application.Service;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.Managment.ViewComponents
{
    public class MainSliderViewComponent : ViewComponent
    {

        private readonly ISliderService _sliderService;

        public MainSliderViewComponent(ISliderService sliderService)
        {
            this._sliderService = sliderService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var slider = await _sliderService.GetAll().AsNoTracking().Include(s=>s.Files).FirstOrDefaultAsync(s => s.Name == "MainPage");
            if (slider == null)
            {
                slider = new Slider
                {

                    Name = "MainPage",
                    CreationTime = DateTime.Now
                };
                await _sliderService.Create(slider);
            }
            return View(slider);
        }
    }
}
