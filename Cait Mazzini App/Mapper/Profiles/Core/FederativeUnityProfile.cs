using AutoMapper;
using CaitMazziniApp.DTOs;
using CaitMazziniApp.Models.Core;
using CaitMazziniApp.ViewModels;

namespace CaitMazziniApp.Mapper.Profiles.Core
{
    public class FederativeUnityProfile : Profile
    {
        public FederativeUnityProfile()
        {
            CreateMap<FederativeUnity, FederativeUnityViewModel>();
            CreateMap<FederativeUnityDTO, FederativeUnity>();
        }
    }
}
