using AutoMapper;
using CaitMazziniApp.Database.Repositories.Interfaces;
using CaitMazziniApp.DTOs;
using CaitMazziniApp.Models.Core;
using CaitMazziniApp.ViewModels;
using Microsoft.AspNetCore.Components;

namespace CaitMazziniApp.Controllers
{
    [Route("[controller]")]
    public class CountriesController : APIResourceController<CountryDTO, CountryViewModel, Country, IGenericRepository<Country, int>>
    {
        public CountriesController(IGenericRepository<Country, int> genericRepository, IMapper mapper) : base(genericRepository, mapper)
        {
              
        }
    }
}
