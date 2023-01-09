using Psinder.Core.Model;
using System.ComponentModel.DataAnnotations;

namespace Psinder.Web.Models
{
    public class UserLogInModelView
    {
        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
