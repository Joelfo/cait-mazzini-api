using AutoMapper;
using CaitMazziniApp.DTOs;
using CaitMazziniApp.Models.Core;
using CaitMazziniApp.ViewModels;
using System.Reflection.Metadata;

namespace CaitMazziniApp.Mapper.Profiles.Core
{
    public class DistrictProfile : Profile
    {
        public DistrictProfile()
        {
            CreateMap<DistrictDTO, District>();
            CreateMap<District, DistrictViewModel>();
        }
    }
}
