using AutoMapper;
using Psinder.Core.Model;
using Psinder.Web.Models;
using Psinder.Web.Models.Dog;

namespace Psinder.Web.Mapping
{
    public class DogProfile : Profile
    {
        public DogProfile()
        {
            CreateMap<DogCreateModelView, Dog>();

            CreateMap<Dog, DogEditModelView>()
                .ReverseMap();

            CreateMap<Dog, DogDeleteModelView>();

            CreateMap<Dog, DogDetailsModelView>();
        }
    }
}
