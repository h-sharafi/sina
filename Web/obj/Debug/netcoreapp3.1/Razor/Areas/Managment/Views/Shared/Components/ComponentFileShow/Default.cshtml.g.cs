#pragma checksum "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/ComponentFileShow/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a511c09e23b0c6bd4dd3600eb26ffc1886183fbd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Managment_Views_Shared_Components_ComponentFileShow_Default), @"mvc.1.0.view", @"/Areas/Managment/Views/Shared/Components/ComponentFileShow/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a511c09e23b0c6bd4dd3600eb26ffc1886183fbd", @"/Areas/Managment/Views/Shared/Components/ComponentFileShow/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d45bb915a3b7839949d03b0a776d96c215f3ce38", @"/Areas/Managment/Views/_ViewImports.cshtml")]
    public class Areas_Managment_Views_Shared_Components_ComponentFileShow_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<List<File>, int, int, int, string, short?>>
    {
        private global::AspNetCore.Areas_Managment_Views_Shared_Components_ComponentFileShow_Default.__Generated__SelectFileCategoryViewComponentTagHelper __SelectFileCategoryViewComponentTagHelper;
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 11rem;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n\n\n\n<div class=\"container\">\n    <div class=\"row\">\n        <div class=\"col-md-4\" style=\"margin: 0px auto;margin-right: 0px;padding: 0px 30px;border-radius: 7px;\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:select-file-category", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a511c09e23b0c6bd4dd3600eb26ffc1886183fbd5504", async() => {
            }
            );
            __SelectFileCategoryViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Areas_Managment_Views_Shared_Components_ComponentFileShow_Default.__Generated__SelectFileCategoryViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__SelectFileCategoryViewComponentTagHelper);
#nullable restore
#line 9 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/ComponentFileShow/Default.cshtml"
__SelectFileCategoryViewComponentTagHelper.selectedId = (Model.Item6 !=null ? Model.Item6.Value  : (short)0);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("selected-id", __SelectFileCategoryViewComponentTagHelper.selectedId, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 9 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/ComponentFileShow/Default.cshtml"
                                                                                                                        WriteLiteral($"{Model.Item5}changeCategory");

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __SelectFileCategoryViewComponentTagHelper.selectFileCategoryCls = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("select-file-category-cls", __SelectFileCategoryViewComponentTagHelper.selectFileCategoryCls, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </div>\n        <div class=\"col-md-8\" id=\"fileShowId\" style=\"margin: 0px auto; margin-left: 0px\">\n            <div class=\"row\">\n");
#nullable restore
#line 13 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/ComponentFileShow/Default.cshtml"
                 if (Model.Item1.Count() == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-12\">\n                        <p class=\"alert alert-info\">هیچ فایلی برای  نمایش در این دسته بندی وجود ندارد</p>\n                    </div>\n");
#nullable restore
#line 18 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/ComponentFileShow/Default.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/ComponentFileShow/Default.cshtml"
                 foreach (var file in Model.Item1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"card-deck col-md-4 col-lg-3\">\n                        <div class=\"card\">\n");
#nullable restore
#line 23 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/ComponentFileShow/Default.cshtml"
                             if (file.FileType.Contains("image"))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a511c09e23b0c6bd4dd3600eb26ffc1886183fbd9494", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1159, "~/UplodedFiles/", 1159, 15, true);
#nullable restore
#line 25 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/ComponentFileShow/Default.cshtml"
AddHtmlAttributeValue("", 1174, file.FileName, 1174, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 25 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/ComponentFileShow/Default.cshtml"
AddHtmlAttributeValue("", 1197, file.Name, 1197, 12, false);

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
#line 26 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/ComponentFileShow/Default.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a511c09e23b0c6bd4dd3600eb26ffc1886183fbd12040", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1391, "~/UplodedFiles/", 1391, 15, true);
#nullable restore
#line 29 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/ComponentFileShow/Default.cshtml"
AddHtmlAttributeValue("", 1406, file.FileType.Split('/')[0], 1406, 30, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 1436, ".png", 1436, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 29 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/ComponentFileShow/Default.cshtml"
AddHtmlAttributeValue("", 1447, file.Name, 1447, 12, false);

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
#line 30 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/ComponentFileShow/Default.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"card-body\">\n                                <h5 class=\"card-title\">");
#nullable restore
#line 32 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/ComponentFileShow/Default.cshtml"
                                                   Write(file.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                                <p class=\"card-text\">");
#nullable restore
#line 33 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/ComponentFileShow/Default.cshtml"
                                                 Write(file.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            </div>\n                            <div class=\"card-footer\">\n                                <buton");
            BeginWriteAttribute("class", " class=\"", 1821, "\"", 1902, 4);
            WriteAttributeValue("", 1829, "btn", 1829, 3, true);
            WriteAttributeValue(" ", 1832, "btn-outline-info", 1833, 17, true);
            WriteAttributeValue(" ", 1849, "btn-block", 1850, 10, true);
#nullable restore
#line 36 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/ComponentFileShow/Default.cshtml"
WriteAttributeValue(" ", 1859, Model.Item5 != null ? Model.Item5  : "", 1860, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-id=\"");
#nullable restore
#line 36 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/ComponentFileShow/Default.cshtml"
                                                                                                                             Write(file.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">انتخاب</buton>\n                            </div>\n                        </div>\n                    </div>\n");
#nullable restore
#line 40 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/ComponentFileShow/Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n\n            <hr />\n\n            <nav aria-label=\"Page navigation example\">\n                <ul class=\"pagination justify-content-center\">\n");
#nullable restore
#line 47 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/ComponentFileShow/Default.cshtml"
                     if (Model.Item3 > 1)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/ComponentFileShow/Default.cshtml"
                         if (Model.Item2 > 1)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"page-item\">\n                                <button class=\"page-link pageIndexClick btn btn-outline-info\" style=\"margin: 0 2px\" data-pageIndex=\"1\">نخستین</button>\n                            </li>\n");
#nullable restore
#line 54 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/ComponentFileShow/Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/ComponentFileShow/Default.cshtml"
                         if (Model.Item2 > 2)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"page-item\" data-pageIndex=\"");
#nullable restore
#line 57 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/ComponentFileShow/Default.cshtml"
                                                              Write(Model.Item2-1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"> <button class=\"page-link pageIndexClick btn btn-outline-info\" style=\"margin: 0 2px\" data-pageIndex=\"");
#nullable restore
#line 57 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/ComponentFileShow/Default.cshtml"
                                                                                                                                                                                     Write(Model.Item2-1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 57 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/ComponentFileShow/Default.cshtml"
                                                                                                                                                                                                       Write(Model.Item2 - 1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button></li>\n");
#nullable restore
#line 58 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/ComponentFileShow/Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"page-item\" data-pageIndex=\"");
#nullable restore
#line 60 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/ComponentFileShow/Default.cshtml"
                                                          Write(Model.Item2);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><button class=\"page-link pageIndexClick btn btn-outline-info\" style=\"margin: 0 2px\" data-pageIndex=\"");
#nullable restore
#line 60 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/ComponentFileShow/Default.cshtml"
                                                                                                                                                                              Write(Model.Item2);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 60 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/ComponentFileShow/Default.cshtml"
                                                                                                                                                                                              Write(Model.Item2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button></li>\n");
#nullable restore
#line 61 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/ComponentFileShow/Default.cshtml"
                         if (Model.Item2 < Model.Item3 - 1)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"page-item\" data-pageIndex=\"");
#nullable restore
#line 63 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/ComponentFileShow/Default.cshtml"
                                                              Write(Model.Item2 + 1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><button class=\"page-link pageIndexClick btn btn-outline-info\" style=\"margin: 0 2px\" data-pageIndex=\"");
#nullable restore
#line 63 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/ComponentFileShow/Default.cshtml"
                                                                                                                                                                                      Write(Model.Item2 + 1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 63 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/ComponentFileShow/Default.cshtml"
                                                                                                                                                                                                          Write(Model.Item2 + 1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button></li>\n");
#nullable restore
#line 64 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/ComponentFileShow/Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/ComponentFileShow/Default.cshtml"
                         if (Model.Item2 < Model.Item3)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"page-item\" data-pageIndex=\"");
#nullable restore
#line 67 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/ComponentFileShow/Default.cshtml"
                                                              Write(Model.Item3);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><button class=\"page-link pageIndexClick btn btn-outline-info\" style=\"margin: 0 2px\" data-pageIndex=\"");
#nullable restore
#line 67 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/ComponentFileShow/Default.cshtml"
                                                                                                                                                                                  Write(Model.Item3);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">پایانی</button></li>\n");
#nullable restore
#line 68 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/ComponentFileShow/Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "/media/sharafi/EE065EF8065EC16F/Sina-second/Sina-master/Web/Areas/Managment/Views/Shared/Components/ComponentFileShow/Default.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\n            </nav>\n\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<List<File>, int, int, int, string, short?>> Html { get; private set; }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:select-file-category")]
        public class __Generated__SelectFileCategoryViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper __helper = null;
            public __Generated__SelectFileCategoryViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                __helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public System.Int16 selectedId { get; set; }
            public System.String selectFileCategoryCls { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext __context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput __output)
            {
                (__helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var __helperContent = await __helper.InvokeAsync("SelectFileCategory", new { selectedId, selectFileCategoryCls });
                __output.TagName = null;
                __output.Content.SetHtmlContent(__helperContent);
            }
        }
    }
}
#pragma warning restore 1591