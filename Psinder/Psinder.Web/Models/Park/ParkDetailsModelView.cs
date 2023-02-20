using System.ComponentModel.DataAnnotations;

namespace Psinder.Web.Models.Park
{
    public class ParkDetailsModelView
    {
        public int Id { get; set; }
        [Display(Name = "Park")]
        public string NamePark { get; set; }
        [Display(Name = "Kraj")]
        public string Country { get; set; }
        [Display(Name = "Ulica")]
        public string Street { get; set; }
        [Display(Name = "Miasto")]
        public string City { get; set; }
        [Display(Name = "Kod pocztowy")]
        public string PostalCode { get; set; }
    }
}
