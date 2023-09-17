using AutoMapper;
using Cait_Mazzini_App.Database.Repositories.Interfaces;
using Cait_Mazzini_App.DTOs;
using Cait_Mazzini_App.Models;
using Cait_Mazzini_App.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Cait_Mazzini_App.Controllers
{
    [Route("[controller]")]
    public class CitiesController : APIResourceController<CityDTO, CityViewModel, City, IGenericRepository<City, int>>
    {
        public CitiesController(IGenericRepository<City, int> genericRepository, IMapper mapper) : base(genericRepository, mapper)
        { 
        }
    }
}
