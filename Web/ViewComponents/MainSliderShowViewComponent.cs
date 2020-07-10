using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Application.Service;
using Microsoft.EntityFrameworkCore;

namespace Web.ViewComponents
{
    public class MainSliderShowViewComponent: ViewComponent
    {
        private readonly ISliderService _sliderService;

        public MainSliderShowViewComponent(ISliderService sliderService)
        {
            this._sliderService = sliderService;
        }
        public async Task<ViewViewComponentResult> InvokeAsync()
        {
            var slider =await _sliderService.GetAll().AsNoTracking().Include(s=>s.Files).FirstOrDefaultAsync(s => s.Name == "MainPage");
            return View(slider);
        }
    }
}
