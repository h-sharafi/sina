#pragma checksum "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/SelectLogo/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29db7e7a034ad9620fc7bf276c1042acd9551214"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Managment_Views_Shared_Components_SelectLogo_Default), @"mvc.1.0.view", @"/Areas/Managment/Views/Shared/Components/SelectLogo/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29db7e7a034ad9620fc7bf276c1042acd9551214", @"/Areas/Managment/Views/Shared/Components/SelectLogo/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d45bb915a3b7839949d03b0a776d96c215f3ce38", @"/Areas/Managment/Views/_ViewImports.cshtml")]
    public class Areas_Managment_Views_Shared_Components_SelectLogo_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<File>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:142px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/SelectLogo/Default.cshtml"
  
    string typeId = (string)ViewBag.typeId;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"col-md-4\">\n    <div  style=\"margin:2px; border: 1px dashed; text-align: center; padding: 4px\">\n");
#nullable restore
#line 9 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/SelectLogo/Default.cshtml"
         if (Model != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "29db7e7a034ad9620fc7bf276c1042acd95512145358", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 230, "~/UplodedFiles/", 230, 15, true);
#nullable restore
#line 11 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/SelectLogo/Default.cshtml"
AddHtmlAttributeValue("", 245, Model.FileName, 245, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 12 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/SelectLogo/Default.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p class=\"alert alert-danger\">یک تصویر به عنوان لوگو انتخاب کنید</p>\n");
#nullable restore
#line 16 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/SelectLogo/Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>\n<div class=\"col-md-8\">\n    <div style=\"margin:2px\">\n        <button class=\"btn btn-outline-warning \" id=\"selectCoverImage\" data-type=\"");
#nullable restore
#line 21 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/SelectLogo/Default.cshtml"
                                                                             Write(typeId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">انتخاب  کاور</button>\n");
#nullable restore
#line 22 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/SelectLogo/Default.cshtml"
         if (Model != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div id=\"imageFileInfoId\" class=\"alert alert-info my-3\" style=\"background:#0cf3ffba!important;border-color:#0cf3ffba!important; color: #000 \">\n                <p style=\"margin: 20px 0;\">نام : ");
#nullable restore
#line 25 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/SelectLogo/Default.cshtml"
                                             Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n            </div>\n");
#nullable restore
#line 28 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/SelectLogo/Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<File> Html { get; private set; }
    }
}
#pragma warning restore 1591
