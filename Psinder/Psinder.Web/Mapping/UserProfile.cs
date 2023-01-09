using AutoMapper;
using Psinder.Core.Model;
using Psinder.Web.Models;

namespace Psinder.Web.Mapping
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserCreateModelView, User>();
            CreateMap<User, UserEditModelView>()
                .ReverseMap();

            CreateMap<User, UserDeleteModelView>()
                .ForMember(dto => dto.PasswordConfirm, expr => expr.Ignore());
           


            CreateMap<User, UserDetailsModelView>()
                .ForMember(dto => dto.UserName, expr => expr.MapFrom(x => x.UserName))
                .ForMember(dto => dto.Email, expr => expr.MapFrom(x => x.Email));    
         

        }

    }
}
