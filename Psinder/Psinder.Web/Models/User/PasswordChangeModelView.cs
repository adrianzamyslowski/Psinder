using Psinder.Core.Model;
using System.ComponentModel.DataAnnotations;

namespace Psinder.Web.Models.User
{
    public class PasswordChangeModelView
    {
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Wprowadź akutalne hasło")]
        [DataType(DataType.Password)]
        public string CurrentPassword { get; set; }

        [Required]
        [Display(Name = "Wprowadz nowe hasło")]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }

        [Required]
        [Display(Name = "Powtórz nowe hasło")]
        [MinLength(8)]
        [DataType(DataType.Password)]
        [Compare("NewPassword", ErrorMessage = "Różne hasło")]
        public string ConfirmPassword { get; set; }
    }
}
