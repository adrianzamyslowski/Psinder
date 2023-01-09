using Psinder.Core.Model;
using System.ComponentModel.DataAnnotations;

namespace Psinder.Web.Models
{
    public class UserDetailsModelView
    {
        [Display(Name = "Nazwa użytkownika")]
        public string UserName { get; set; }

        [Display(Name = "Adres e-mail")]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Data urodzenia")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        public List<Dog> Dogs = new();
    }
}
