using Psinder.Core.Model;
using System.ComponentModel.DataAnnotations;


namespace Psinder.Web.Models.Meeting
{
    public class MeetingCreateModelView
    {
        public int Id { get; set; }

        [Display(Name="Start wydarzenia")]
        [Required]
        public DateTime StartDate { get; set; }

        [Display(Name = "Zakończenie wydarzenia")]
        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public int ParkId { get; set; }

        [Required]
        public string UserId { get; set; }

        public List<DogOnMeeting> DogOnMeetings { get; set; } = new();
        public List<UserOnMeeting> UsersOnMeeting { get; set; } = new();

        public List<Core.Model.Dog> Dog { get; set; }

        public int DogToAddId { get; set; }
    }
}
