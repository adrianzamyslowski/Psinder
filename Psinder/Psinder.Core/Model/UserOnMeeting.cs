using System.ComponentModel.DataAnnotations.Schema;

namespace Psinder.Core.Model
{
    public class UserOnMeeting
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public User User { get; set; }

        [ForeignKey(nameof(Meeting))]
        public int MeetingId { get; set; }
        public Meeting Meeting { get; set; }
    }
}