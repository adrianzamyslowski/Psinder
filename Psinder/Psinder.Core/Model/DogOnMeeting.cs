using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psinder.Core.Model
{
    public class DogOnMeeting
    {
        public int Id { get; set; }
        public string DogOwnerId { get; set; }

        [ForeignKey(nameof(Dog))]
        public int DogId { get; set; }
        public Dog Dog { get; set; }

        [ForeignKey(nameof(Meeting))]
        public int MeetingId { get; set; }
        public Meeting Meeting { get; set; }

    }
}
