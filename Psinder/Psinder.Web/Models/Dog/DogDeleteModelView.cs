using Psinder.Core.Model.Enums;
using Psinder.Core.Model;
using System.ComponentModel.DataAnnotations;

namespace Psinder.Web.Models.Dog
{
    public class DogDeleteModelView
    {
        public int Id { get; set; }
        [Display(Name = "Imię zwierzaka")]
        [Required]
        public string Name { get; set; }
        //[Display(Name = "Potwierdz imię zwierzaka")]
        //[Required]
        //public string ConfirmName { get; set; }

        [Display(Name = "Data urodzenia")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime DateOfBirth { get; set; }
    }
}
