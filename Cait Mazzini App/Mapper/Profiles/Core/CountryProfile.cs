using AutoMapper;
using CaitMazziniApp.DTOs;
using CaitMazziniApp.Models.Core;
using CaitMazziniApp.ViewModels;

namespace CaitMazziniApp.Mapper.Profiles.Core
{
    public class CountryProfile : Profile
    {
        public CountryProfile()
        {
            CreateMap<Country, CountryViewModel>();
            CreateMap<CountryDTO, Country>();
        }
    }
}
