using Psinder.Core.Model.Enums;
using Psinder.Core.Model;
using System.ComponentModel.DataAnnotations;

namespace Psinder.Web.Models.Dog
{
    public class DogEditModelView
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
