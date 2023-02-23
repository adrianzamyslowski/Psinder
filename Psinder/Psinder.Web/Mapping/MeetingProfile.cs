using AutoMapper;
using Psinder.Core.Model;
using Psinder.Web.Models.Meeting;
using Psinder.Web.Models.Park;

namespace Psinder.Web.Mapping
{
    public class MeetingProfile : Profile
    {

        public MeetingProfile()
        {

            CreateMap<MeetingCreateModelView, Meeting>();

        }
    }
}
