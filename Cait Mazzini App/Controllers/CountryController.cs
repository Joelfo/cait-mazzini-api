using AutoMapper;
using Cait_Mazzini_App.Database.Repositories.Interfaces;
using Cait_Mazzini_App.DTOs;
using Cait_Mazzini_App.Models;

namespace Cait_Mazzini_App.Controllers
{
    public class CountryController : APIResourceController<CountryDTO, Country>
    {
        public CountryController(IGenericRepository<Country, int> genericRepository, IMapper mapper) : base(genericRepository, mapper)
        {
              
        }
    }
}
