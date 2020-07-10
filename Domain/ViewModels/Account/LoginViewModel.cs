using System.ComponentModel.DataAnnotations;

namespace Domain.ViewModels
{
    public class LoginViewModel
    {
        [Display(Name = "ایمیل  ")]
        [Required(ErrorMessage = "وارد کردن {0}  ضروری است")]
        public string Email { get; set; }

        [Display(Name = "ایمیل  ")]
        [Required(ErrorMessage = "وارد کردن {0}  ضروری است")]
        public string Password { get; set; }
    }
}