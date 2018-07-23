using AutoMapper;
using UserRegistration.Models;
using UserRegistration.ViewModels;

namespace UserRegistration
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserViewModel>()
                .ForMember(x => x.ConfirmPassword, opt => opt.Ignore())
                .ForMember(x => x.Password, opt => opt.Ignore());
            CreateMap<UserViewModel, User>();
        }
    }
}
