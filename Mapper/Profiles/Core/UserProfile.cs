using AutoMapper;
using CaitMazziniApp.Api.DTOs.Core;
using CaitMazziniApp.Mapper.Resolvers;
using CaitMazziniApp.Models.Core;
using CaitMazziniApp.ViewModels;

namespace CaitMazziniApp.Mapper.Profiles.Core
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserViewModel>();
            CreateMap<UserDTO, User>()
                .ForMember(x => x.HashedPassowrd, opt => opt.MapFrom<HashedPasswordResolver>());
        }
    }
}
