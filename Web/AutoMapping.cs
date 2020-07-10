using AutoMapper;
using Domain;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<SiteSettingViewModel, SiteSetting>();
            CreateMap<SiteSetting, SiteSettingViewModel>();
            CreateMap<FileViewModel , File>();
        }
    }
}
