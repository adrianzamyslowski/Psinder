using Psinder.Core.Model;
using Psinder.Core.Model.Enums;
using System.ComponentModel.DataAnnotations;

namespace Psinder.Web.Models.Dog
{
    public class DogDetailsModelView
    {
        public int Id { get; set; }
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
        public string DogBreeds { get; set; }
    }
}
