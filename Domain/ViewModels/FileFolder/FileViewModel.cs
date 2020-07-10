using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Domain.ViewModels
{
    public class FileViewModel : File
    {
        [Display(Name="فایل")]
        public IFormFile FormFile { get; set; }
    }
}