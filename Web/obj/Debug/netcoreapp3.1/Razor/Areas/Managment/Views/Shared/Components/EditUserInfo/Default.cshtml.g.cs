#pragma checksum "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/EditUserInfo/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31041afb7fd803057b5caeb67b55c87908cd04ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Managment_Views_Shared_Components_EditUserInfo_Default), @"mvc.1.0.view", @"/Areas/Managment/Views/Shared/Components/EditUserInfo/Default.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/_ViewImports.cshtml"
using Domain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/_ViewImports.cshtml"
using Domain.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/_ViewImports.cshtml"
using Domain.ViewModels.Public;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/_ViewImports.cshtml"
using Web.Areas.Managment.ViewComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/_ViewImports.cshtml"
using Domain.ViewModels.FileFolder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/_ViewImports.cshtml"
using Infrastructure.EM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31041afb7fd803057b5caeb67b55c87908cd04ca", @"/Areas/Managment/Views/Shared/Components/EditUserInfo/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d45bb915a3b7839949d03b0a776d96c215f3ce38", @"/Areas/Managment/Views/_ViewImports.cshtml")]
    public class Areas_Managment_Views_Shared_Components_EditUserInfo_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AppUser>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"form-group\">\n    <div style=\"background: #E3E3E3 ; padding: 20px\">\n         <button class=\"btn btn-outline-info\" id=\"selectUSerbtnId\"style=\"margin: 5px\">انتخاب کاربر</button>\n");
#nullable restore
#line 6 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/EditUserInfo/Default.cshtml"
         if (Model != null)
        {
           

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row\">\n                <div class=\"col-md-12\" style=\"margin: 20px 3px\">\n                    <spam>نام</spam> : <span class=\"alert alert-info\" style=\"padding : 5px\">");
#nullable restore
#line 11 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/EditUserInfo/Default.cshtml"
                                                                                       Write(Model.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                </div>\n                <div class=\"col-md-12\" style=\"margin: 20px 3px\">\n                    <spam>ایمیل</spam> : <span class=\"alert alert-info\" style=\"padding : 5px\">");
#nullable restore
#line 14 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/EditUserInfo/Default.cshtml"
                                                                                         Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                </div>\n                <div class=\"col-md-12\" style=\"margin: 20px 3px\">\n                    <spam>تاریخ عضویت</spam>:<span class=\"alert alert-info\" style=\"padding : 5px\">\n");
#nullable restore
#line 18 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/EditUserInfo/Default.cshtml"
                         if (Model.CreationDateTime > DateTime.MinValue)
                        {
                            var date = Model.CreationDateTime.ToString();

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span>");
#nullable restore
#line 21 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/EditUserInfo/Default.cshtml"
                             Write(date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n");
#nullable restore
#line 22 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/EditUserInfo/Default.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span>بدون تاریخ عضویت</span>\n");
#nullable restore
#line 26 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/EditUserInfo/Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </span>\n\n                </div>\n\n            </div>\n");
#nullable restore
#line 32 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/EditUserInfo/Default.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p class=\"alert alert-danger\">یک کاربر اینتخاب کنید</p>\n");
#nullable restore
#line 36 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/EditUserInfo/Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AppUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
