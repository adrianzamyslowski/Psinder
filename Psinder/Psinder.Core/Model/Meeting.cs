using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psinder.Core.Model
{
    public class Meeting
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        [ForeignKey(nameof(Park))]
        public int ParkId { get; set; }
        public Park Park { get; set; }

        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public User User { get; set; }

        public List<DogOnMeeting> DogOnMeetings { get; set; } = new();

        public List<UserOnMeeting> UsersOnMeeting { get; set; }






    }
}
