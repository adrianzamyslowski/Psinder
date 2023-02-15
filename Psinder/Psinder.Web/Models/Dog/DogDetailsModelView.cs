using Psinder.Core.Model;
using Psinder.Core.Model.Enums;
using System.ComponentModel.DataAnnotations;

namespace Psinder.Web.Models.Dog
{
    public class DogDetailsModelView
    {
        [Display(Name = "Imię zwierzaka")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Data urodzenia")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Płeć")]
        [Required]
        public Gender Gender { get; set; }

        [Display(Name = "Rasa")]
        [Required]
        public DogBreeds DogBreeds { get; set; }
    }
}
