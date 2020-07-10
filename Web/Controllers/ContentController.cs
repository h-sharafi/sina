using Application.Service;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Infrastructure.EM;
using Domain;

namespace Web.Controllers
{
    [ApiController]

    public class ContentController : BaseController
    {
        private readonly IContentService _contentService;
        private readonly IContentTypeService _contentTypeService;
        private readonly IFileService _fileService;

        public ContentController(IContentService contentService, IContentTypeService contentTypeService, IFileService fileService)
        {
            this._fileService = fileService;
            this._contentTypeService = contentTypeService;
            _contentService = contentService;
        }
        [Route("ContentType/{id?}/{name?}")]
        public async Task<IActionResult> Index(short id, string name = null)
        {

            if (id == 0) return RedirectToAction("index", "Home");
            var contents = await _contentService.GetAll().AsNoTracking().Include(c => c.CoverImage).Include(c=>c.ProfileImage).Include(c => c.ContentType).Where(c => c.ContentTypeId == id && c.IsActive).ToListAsync();
            return View(contents);
        }
        [Route("Content/{id?}/{name?}")]
        public async Task<IActionResult> ContentDetails(short id)
        {
            if (id == 0) return RedirectToAction("index", "Home");
            var content = await _contentService.GetAll().AsNoTracking().Include(c => c.ContentType).Include(c => c.CreationUser).ThenInclude(c => c.Team).ThenInclude(t=>t.ProfileImage).Include(c => c.Comments).Include(c=>c.CoverImage).Where(c => c.IsActive).FirstOrDefaultAsync(c => c.Id == id);
            if (content == null) return RedirectToAction("Index", "Home");
            await LasSeenPlus(content);
            var contentText = content.Text;
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
        
        private async Task LasSeenPlus(Content content)
        {
            content.TotalSeen += 1;
            await _contentService.Update(content);
        }
    }
}