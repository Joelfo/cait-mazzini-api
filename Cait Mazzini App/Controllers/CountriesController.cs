using AutoMapper;
using Cait_Mazzini_App.Database.Repositories.Interfaces;
using Cait_Mazzini_App.DTOs;
using Cait_Mazzini_App.Models;
using Cait_Mazzini_App.ViewModels;
using Microsoft.AspNetCore.Components;

namespace Cait_Mazzini_App.Controllers
{
    [Route("[controller]")]
    public class CountriesController : APIResourceController<CountryDTO, CityViewModel, Country, IGenericRepository<Country, int>>
    {
        public CountriesController(IGenericRepository<Country, int> genericRepository, IMapper mapper) : base(genericRepository, mapper)
        {
              
        }
    }
}
