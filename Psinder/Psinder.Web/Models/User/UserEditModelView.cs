using Psinder.Core.Model;
using System.ComponentModel.DataAnnotations;

namespace Psinder.Web.Models
{
    public class UserEditModelView
    {
        [Display(Name = "Nazwa użytkownika")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Adres e-mail")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Data urodzenia")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
    }
}
