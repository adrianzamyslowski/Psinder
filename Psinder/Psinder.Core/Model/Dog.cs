using Psinder.Core.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psinder.Core.Model
{
    public class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }


        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public User User { get; set; }


        [ForeignKey(nameof(DogBreeds))]
        public int DogBreedsId { get; set; }
        public DogBreeds DogBreeds { get; set; }

        public List<DogOnMeeting> DogOnMeetings { get; set; } = new();
    }
}
