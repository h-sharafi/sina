using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Service;
using Infrastructure.Attributes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VestaEShop.Web.Areas.Management.Controllers;
using Web.Areas.Managment.Models;

namespace Web.Areas.Managment.Controllers
{
    [Title("داشبورد")]
    [Key("8c7c577c-c748-4e75-b24f-e4c7fdf80eb6")]
    [Icon("fa fa-dashboard")]
    [Url("/")]
    public class HomeController : ManagementController
    {
        private readonly IFileService _fileService;

        public HomeController(IFileService fileService)
        {
            _fileService = fileService;
        }
        [Title("داشبورد")]
        [Key("fe24a50f-9afe-4878-a4ae-0cd9dae40be1")]
        [Icon("fa fa-dashboard")]
        [DontSideBarShow]
        public async Task<IActionResult> Index()
        {
            var model = new HomeViewModel()
            {
                PodcastCount = await _fileService.GetAll().Where(p => p.IsPodcast).CountAsync(),
                VideoCount = await _fileService.GetAll().Where(p => p.IsPodcast).CountAsync(),
                PaperCount = await _fileService.GetAll().Where(p => p.IsPodcast).CountAsync()

            };
            return View(model);
        }
     
    }
}