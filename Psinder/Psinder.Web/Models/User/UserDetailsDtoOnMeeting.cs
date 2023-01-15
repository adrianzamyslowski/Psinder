using System.ComponentModel.DataAnnotations;

namespace Psinder.Web.Models.User
{
    public class UserDetailsDtoOnMeeting
    {
        [Display(Name = "Nazwa użytownika")]
        public string UserName { get; set; }

        [Display(Name ="Pies na spacerze")]
        public string DogOnMeeting { get; set; }
    }
}
