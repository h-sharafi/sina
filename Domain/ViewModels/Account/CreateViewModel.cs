using System.ComponentModel.DataAnnotations;

namespace Domain.ViewModels
{
    public class CreateViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }
    
    }
}