#pragma checksum "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/FileWork/FileCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4f398deb5c4840e245c1d71ab73870cb87c799e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Managment_Views_FileWork_FileCategory), @"mvc.1.0.view", @"/Areas/Managment/Views/FileWork/FileCategory.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4f398deb5c4840e245c1d71ab73870cb87c799e", @"/Areas/Managment/Views/FileWork/FileCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d45bb915a3b7839949d03b0a776d96c215f3ce38", @"/Areas/Managment/Views/_ViewImports.cshtml")]
    public class Areas_Managment_Views_FileWork_FileCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Domain.FileCategory>>
    {
        private global::AspNetCore.Areas_Managment_Views_FileWork_FileCategory.__Generated__FileCategoryViewComponentTagHelper __FileCategoryViewComponentTagHelper;
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_FileWorkHeader", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/Managment/fileCategory.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/FileWork/FileCategory.cshtml"
  
    ViewData["Title"] = "FileCategory";
    Layout = "~/Areas/Managment/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d4f398deb5c4840e245c1d71ab73870cb87c799e5576", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n<button class=\"btn btn-outline-success\" style=\"margin: 20px 69px;\" id=\"CreateCategory\">ایجاد دسته بندی</button>\n<div class=\"container\" id=\"fcId\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:file-category", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4f398deb5c4840e245c1d71ab73870cb87c799e6839", async() => {
            }
            );
            __FileCategoryViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Areas_Managment_Views_FileWork_FileCategory.__Generated__FileCategoryViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__FileCategoryViewComponentTagHelper);
#nullable restore
#line 12 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/FileWork/FileCategory.cshtml"
__FileCategoryViewComponentTagHelper.filecategorys = Model;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("filecategorys", __FileCategoryViewComponentTagHelper.filecategorys, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4f398deb5c4840e245c1d71ab73870cb87c799e8334", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Domain.FileCategory>> Html { get; private set; }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:file-category")]
        public class __Generated__FileCategoryViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper __helper = null;
            public __Generated__FileCategoryViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                __helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public System.Collections.Generic.List<Domain.FileCategory> filecategorys { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext __context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput __output)
            {
                (__helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var __helperContent = await __helper.InvokeAsync("FileCategory", new { filecategorys });
                __output.TagName = null;
                __output.Content.SetHtmlContent(__helperContent);
            }
        }
    }
}
#pragma warning restore 1591