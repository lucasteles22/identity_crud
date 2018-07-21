using AutoMapper;
using UserRegistration.Models;
using UserRegistration.ViewModels;

namespace UserRegistration
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserViewModel>();
            CreateMap<UserViewModel, User>();
        }
    }
}
