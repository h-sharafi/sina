#pragma checksum "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Views/Shared/Components/HeadeTags/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "393a9bc7f9214a85a6c229d7ff0c87c31d97b9e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_HeadeTags_Default), @"mvc.1.0.view", @"/Views/Shared/Components/HeadeTags/Default.cshtml")]
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
#line 1 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Views/_ViewImports.cshtml"
using Application.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Views/_ViewImports.cshtml"
using Domain.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Views/_ViewImports.cshtml"
using Domain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Views/_ViewImports.cshtml"
using Web.Areas.Managment.ViewComponents;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"393a9bc7f9214a85a6c229d7ff0c87c31d97b9e7", @"/Views/Shared/Components/HeadeTags/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"993aa8fb61fe997385bec1e0ff0cec97aabc7565", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_HeadeTags_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<SiteSetting, string>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("shortcut icon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("image/x-icon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Views/Shared/Components/HeadeTags/Default.cshtml"
 if (Model != null && Model.Item1 != null &&  Model.Item1.FavIcon != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "393a9bc7f9214a85a6c229d7ff0c87c31d97b9e74537", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 167, "~/UplodedFiles/", 167, 15, true);
#nullable restore
#line 4 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Views/Shared/Components/HeadeTags/Default.cshtml"
AddHtmlAttributeValue("", 182, Model.Item1.FavIcon.FileName, 182, 31, false);

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
            WriteLiteral("\n    <title>");
#nullable restore
#line 5 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Views/Shared/Components/HeadeTags/Default.cshtml"
       Write(Model.Item1.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("| ");
#nullable restore
#line 5 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Views/Shared/Components/HeadeTags/Default.cshtml"
                             Write(Model.Item2 != null ? Model.Item2 : "خانه");

#line default
#line hidden
#nullable disable
            WriteLiteral("</title>\n");
#nullable restore
#line 6 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Views/Shared/Components/HeadeTags/Default.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<SiteSetting, string>> Html { get; private set; }
    }
}
#pragma warning restore 1591
