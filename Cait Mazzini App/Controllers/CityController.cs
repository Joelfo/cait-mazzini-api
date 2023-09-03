using AutoMapper;
using Cait_Mazzini_App.Database.Repositories.Interfaces;
using Cait_Mazzini_App.DTOs;
using Cait_Mazzini_App.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cait_Mazzini_App.Controllers
{
    [Route("[controller]")]
    public class CityController : APIResourceController<CityDTO, City>
    {
        public CityController(IGenericRepository<City, int> genericRepository, IMapper mapper) : base(genericRepository, mapper)
        { 
        }
    }
}
