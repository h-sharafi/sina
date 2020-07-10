using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class UploadInfo : AuditableEntity<short>
    {
        /// <summary>
        /// تعداد کل فایل های اپلودی
        /// </summary>
        /// <value></value>
        public int TotalUploads { get; set; }
        /// <summary>
        /// تاریخ اخرین آپلود
        /// </summary>
        /// <value></value>
        public DateTime LastUploadDate { get; set; }
        public short FileId { get; set; }
        /// <summary>
        /// اخریم فایل اپلودی
        /// </summary>
        /// <value></value>
        [ForeignKey(nameof(FileId))]
        public File File { get; set; }
        [ForeignKey(nameof(UserId))]
        public AppUser User { get; set; }
        public string UserId { get; set; }

    }
}