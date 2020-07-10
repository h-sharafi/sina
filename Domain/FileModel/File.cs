using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Domain.Common;

namespace Domain
{
    public class File : AuditableEntity<short>
    {
        /// <summary>
        /// نوع این فایل
        /// </summary>
        /// <value></value>
        // public AccessAbleFile AccessAbleFile { get; set; }
        // public short? AccessAbleFileId { get; set; }
        /// <summary>
        /// مشخص میکند چه کسی این فایل ها را ویرایش کرده است
        /// </summary>
        /// <value></value>
        public ICollection<ModifiedUser<File>> FileModifiedUser { get; set; }
        public string FileName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [Display(Name = "نام ")]
        public string Name { get; set; }
        [Display(Name = "توضیحات")]
        public string Description { get; set; }
        public string CartTitle { get; set; }
        [Display(Name = "عنوان")]
        public string Title { get; set; }
        public FileCategory FileCategory { get; set; }
        [Display(Name = "دسته بندی")]
        public short? FileCategoryId { get; set; }
        public long Length { get; set; }
        public bool IsPodcast { get; set; }

        public string FileType { get; set; }
        public int Duration { get; set; }
        public Slider Slider { get; set; }
        public short? SliderId { get; set; }
        public ICollection<Content> ContentCoverImages { get; set; }
        public ICollection<Content> ContentProfileImages { get; set; }
        public ICollection<Team> Teams { get; set; }

        public SiteSetting LogoSiteSetting { get; set; }
        public SiteSetting FavIconSetting { get; set; }
        public SiteSetting FooterLogoSiteSetting { get; set; }
       

    }
}