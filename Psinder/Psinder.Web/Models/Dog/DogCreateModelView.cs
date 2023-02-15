using Psinder.Core.Model;
using Psinder.Core.Model.Enums;
using System.ComponentModel.DataAnnotations;

namespace Psinder.Web.Models.Dog
{
    public class DogCreateModelView
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
        public string DogBreeds { get; set; }
    }
}
