#pragma checksum "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/SideBar/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1845db4ec60b4727d33973bf25f0dcb2c05139d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Managment_Views_Shared_Components_SideBar_Default), @"mvc.1.0.view", @"/Areas/Managment/Views/Shared/Components/SideBar/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1845db4ec60b4727d33973bf25f0dcb2c05139d", @"/Areas/Managment/Views/Shared/Components/SideBar/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d45bb915a3b7839949d03b0a776d96c215f3ce38", @"/Areas/Managment/Views/_ViewImports.cshtml")]
    public class Areas_Managment_Views_Shared_Components_SideBar_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SideBarViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("AdminLTE Logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("brand-image img-circle elevation-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("opacity: .8"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-circle elevation-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "managment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<aside class=\"main-sidebar sidebar-dark-primary elevation-4\" style=\"min-height: 608.4px;\">\n    <!-- Brand Logo -->\n    <a href=\"/\" class=\"brand-link\">\n");
#nullable restore
#line 5 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/SideBar/Default.cshtml"
         if (Model?.SiteSetting != null && Model.SiteSetting?.SiteLogo != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e1845db4ec60b4727d33973bf25f0dcb2c05139d6687", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 287, "~/UplodedFiles/", 287, 15, true);
#nullable restore
#line 7 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/SideBar/Default.cshtml"
AddHtmlAttributeValue("", 302, Model.SiteSetting.SiteLogo.FileName, 302, 38, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 8 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/SideBar/Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <span class=""brand-text font-weight-light"">پنل مدیریت</span>
    </a>

    <!-- Sidebar -->
    <div class=""sidebar"" style=""direction: ltr"">
        <div style=""direction: rtl"">
            <!-- Sidebar user panel (optional) -->
            <div class=""user-panel mt-3 pb-3 mb-3 d-flex"">
                <div class=""image"">
");
#nullable restore
#line 18 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/SideBar/Default.cshtml"
                     if (Model.User?.Team?.ProfileImage != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e1845db4ec60b4727d33973bf25f0dcb2c05139d9379", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 889, "~/UplodedFiles/", 889, 15, true);
#nullable restore
#line 20 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/SideBar/Default.cshtml"
AddHtmlAttributeValue("", 904, Model.User.Team.ProfileImage.FileName, 904, 40, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 20 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/SideBar/Default.cshtml"
AddHtmlAttributeValue("", 982, Model.User.DisplayName, 982, 23, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 21 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/SideBar/Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </div>\n                <div class=\"info\">\n                    <a href=\"#\" class=\"d-block\">");
#nullable restore
#line 25 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/SideBar/Default.cshtml"
                                           Write(Model.User.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                </div>\n            </div>\n\n            <!-- Sidebar Menu -->\n            <nav class=\"mt-2\">\n                <ul class=\"nav nav-pills nav-sidebar flex-column\" data-widget=\"treeview\" role=\"menu\" data-accordion=\"false\">\n");
#nullable restore
#line 32 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/SideBar/Default.cshtml"
                     foreach (var sideBar in Model.SideBars)
                    {
                        var actionDatas = sideBar.ActionsList.Where(ac => !ac.IsDontSideBarShow && !ac.RequiresHttpPost).ToList();
                        if (actionDatas.Count > 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li");
            BeginWriteAttribute("class", " class=\"", 1720, "\"", 1808, 3);
            WriteAttributeValue("", 1728, "nav-item", 1728, 8, true);
            WriteAttributeValue(" ", 1736, "has-treeview", 1737, 13, true);
#nullable restore
#line 37 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/SideBar/Default.cshtml"
WriteAttributeValue(" ", 1749, Model.Menu == sideBar.ControllerName ? "menu-open" : "", 1750, 58, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                                <a href=\"#\"");
            BeginWriteAttribute("class", " class=\"", 1854, "\"", 1926, 2);
            WriteAttributeValue("", 1862, "nav-link", 1862, 8, true);
#nullable restore
#line 38 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/SideBar/Default.cshtml"
WriteAttributeValue(" ", 1870, Model.Menu == sideBar.ControllerName ? "active" : "", 1871, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                                    <i");
            BeginWriteAttribute("class", " class=\"", 1967, "\"", 2007, 2);
            WriteAttributeValue("", 1975, "nav-icon", 1975, 8, true);
#nullable restore
#line 39 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/SideBar/Default.cshtml"
WriteAttributeValue(" ", 1983, sideBar.ControllerIcon, 1984, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\n                                    <p>\n                                        ");
#nullable restore
#line 41 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/SideBar/Default.cshtml"
                                   Write(sideBar.ControllerNameLocalized);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                        <i class=\"right fa fa-angle-left\"></i>\n                                    </p>\n                                </a>\n                                <ul class=\"nav nav-treeview\">\n");
#nullable restore
#line 46 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/SideBar/Default.cshtml"
                                     foreach (var item in actionDatas)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li class=\"nav-item\">\n");
            WriteLiteral("\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1845db4ec60b4727d33973bf25f0dcb2c05139d15730", async() => {
                WriteLiteral("\n                                                <i");
                BeginWriteAttribute("class", " class=\"", 3225, "\"", 3258, 2);
#nullable restore
#line 55 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/SideBar/Default.cshtml"
WriteAttributeValue("", 3233, item.ActionIcon, 3233, 16, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 3249, "nav-icon", 3250, 9, true);
                EndWriteAttribute();
                WriteLiteral("></i>\n                                                <p>");
#nullable restore
#line 56 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/SideBar/Default.cshtml"
                                              Write(item.ActionNameLocalized);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/SideBar/Default.cshtml"
                                                                        WriteLiteral(sideBar.ControllerName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-controller", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/SideBar/Default.cshtml"
                                                                                                             WriteLiteral(item.ActionName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3112, "nav-link", 3112, 8, true);
#nullable restore
#line 54 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/SideBar/Default.cshtml"
AddHtmlAttributeValue(" ", 3120, item.ActionName == Model.SubMenu ? "active" : "", 3121, 51, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                        </li>\n");
#nullable restore
#line 59 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/SideBar/Default.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </ul>\n                            </li>\n");
#nullable restore
#line 62 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/SideBar/Default.cshtml"
                        }
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/SideBar/Default.cshtml"
                                                                                   
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\n            </nav>\n            <!-- /.sidebar-menu -->\n        </div>\n    </div>\n    <!-- /.sidebar -->\n</aside>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SideBarViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591