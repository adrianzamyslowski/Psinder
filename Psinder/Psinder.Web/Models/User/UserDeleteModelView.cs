using Psinder.Core.Model;
using System.ComponentModel.DataAnnotations;

namespace Psinder.Web.Models
{
    public class UserDeleteModelView
    {
        [Display(Name = "Nazwa użytkownika")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Potwierdz usunięcie użytkownika - wprowadz hasło")]
        [DataType(DataType.Password)]
        public string PasswordConfirm { get; set; }

        [Display(Name = "Adres e-mail")]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Data urodzenia")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

    }
}
