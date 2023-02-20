using Psinder.Core.Model;
using Psinder.Web.Models.Park;
using AutoMapper;

namespace Psinder.Web.Mapping
{
    public class ParkProfile : Profile
    {
        public ParkProfile()
        {
            CreateMap<ParkCreateModelView, Park>();

            CreateMap<Park, ParkDetailsModelView>();

            CreateMap<Park, ParkEditModelView>()
                    .ReverseMap();

            CreateMap<Park, ParkDeleteModelView>();
        }
    }
}
