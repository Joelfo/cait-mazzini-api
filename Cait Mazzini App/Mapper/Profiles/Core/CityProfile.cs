using AutoMapper;
using CaitMazziniApp.DTOs;
using CaitMazziniApp.Models.Core;
using CaitMazziniApp.ViewModels;

namespace CaitMazziniApp.Mapper.Profiles.Core
{
    public class CityProfile : Profile
    {
        public CityProfile()
        {
            CreateMap<City, CountryViewModel>();
            CreateMap<CityDTO, CountryViewModel>();
        }
    }
}
