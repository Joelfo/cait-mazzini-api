using AutoMapper;
using Cait_Mazzini_App.Database.Repositories.Interfaces;
using Cait_Mazzini_App.DTOs;
using Cait_Mazzini_App.Models;

namespace Cait_Mazzini_App.Controllers
{
    public class DistrictController : APIResourceController<DistrictDTO, District>
    {
        public DistrictController(IGenericRepository<District, int> genericRepository, IMapper mapper) : base(genericRepository, mapper) 
        {
        }
    }
}
