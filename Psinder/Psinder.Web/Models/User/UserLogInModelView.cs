using Psinder.Core.Model;
using System.ComponentModel.DataAnnotations;

namespace Psinder.Web.Models.User
{
    public class UserLogInModelView
    {
        [Required]
        [Display(Name = "Nazwa użytkownika")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Hasło")]
        public string Password { get; set; }
    }
}
