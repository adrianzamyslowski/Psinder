using AutoMapper;
using Psinder.Core.Model;
using Psinder.Web.Models.User;


namespace Psinder.Web.Mapping
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserCreateModelView, User>();

            CreateMap<User, UserEditModelView>()
                .ReverseMap();

            CreateMap<User, PasswordChangeModelView>()
                .ForMember(dto => dto.CurrentPassword, expr => expr.Ignore())
                .ForMember(dto => dto.NewPassword, expr => expr.Ignore())
                .ForMember(dto => dto.ConfirmPassword, expr => expr.Ignore());

            CreateMap<User, UserDeleteModelView>()
                .ForMember(dto => dto.PasswordConfirm, expr => expr.Ignore());

            CreateMap<User, UserDetailsModelView>();                
        }

    }
}
