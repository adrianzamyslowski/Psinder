using System.ComponentModel.DataAnnotations;

namespace Psinder.Web.Models.Park
{
    public class ParkDeleteModelView
    {
        public int Id { get; set; }
        [Display(Name = "Park")]
        public string Country { get; set; }
        [Display(Name = "Ulica")]
        public string Street { get; set; }
        [Display(Name = "Miasto")]
        public string City { get; set; }
    }
}
