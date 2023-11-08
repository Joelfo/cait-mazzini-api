using AutoMapper;
using CaitMazziniApp.DTOs;
using CaitMazziniApp.Models.Core;
using CaitMazziniApp.ViewModels;

namespace CaitMazziniApp.Mapper.Profiles.Core
{
    public class HealthUnityProfile : Profile
    {
        public HealthUnityProfile()
        {
            CreateMap<HealthUnityDTO, HealthUnity>();
            CreateMap<HealthUnity, HealthUnityViewModel>();
        }

    }
}
