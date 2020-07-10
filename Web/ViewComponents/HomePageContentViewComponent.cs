using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Service;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using Infrastructure.EM;
using Domain;

namespace Web.ViewComponents
{
    public class HomePageContentViewComponent : ViewComponent
    {
        private readonly IContentService _contentService;
        private readonly IFileService _fileService;

        public HomePageContentViewComponent(IContentService contentService, IFileService fileService)
        {
            this._contentService = contentService;
            this._fileService = fileService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var content = await _contentService.GetAll().AsNoTracking().FirstOrDefaultAsync(c => c.Name == "MainPage");
            if (content == null)
            {
                return View(new Content());
            }
            content.TotalSeen += 1;
            await _contentService.Update(content);
            var contentText = content.Text;
            // // var document = new HtmlDocument();
            // // document.LoadHtml(contentText);
            // Define a regular expression for repeated words.
            Regex rx = new Regex(@"(\[image{id:).(:,fileId:).(:,imageCmsType:).(:}])", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            MatchCollection matches = rx.Matches(contentText);


            // Report on each match.
            foreach (Match match in matches)
            {
                var txt = match.Value;
                var txtSplit = txt.Split(':');
                var cmsId = short.Parse(txtSplit[1].PersianToEnglish());
                var fileId = short.Parse(txtSplit[3].PersianToEnglish());
                var file = await _fileService.GetAll().AsNoTracking().FirstOrDefaultAsync(f => f.Id == fileId);
                var imageCms = $"<div class='blog-box-layout'><div class=item-img><img src='/UplodedFiles/{file.FileName}' alt='{file.Name}'></div></div>";
                contentText = contentText.Replace(txt, imageCms);
            }
            content.Text = contentText;
            return View(content);
        }
    }
}
