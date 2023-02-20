using System.ComponentModel.DataAnnotations;

namespace Psinder.Web.Models.Park
{
    public class ParkCreateModelView
    {
        public int Id { get; set; }
        [Display(Name = "Park")]
        [Required]
        public string NamePark { get; set; }
        [Display(Name = "Kraj")]
        [Required]
        public string Country { get; set; }
        [Display(Name = "Ulica")]
        [Required]
        public string Street { get; set; }
        [Display(Name = "Miasto")]
        [Required]
        public string City { get; set; }
        [Display(Name = "Kod pocztowy")]
        [Required]
        public string PostalCode { get; set; }
    }
}
