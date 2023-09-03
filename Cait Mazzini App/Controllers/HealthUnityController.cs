using AutoMapper;
using Cait_Mazzini_App.Database.Repositories.Interfaces;
using Cait_Mazzini_App.DTOs;
using Cait_Mazzini_App.Models;
using System.Security.Cryptography.X509Certificates;

namespace Cait_Mazzini_App.Controllers
{
    public class HealthUnityController : APIResourceController<HealthUnityDTO, HealthUnity>
    {
        public HealthUnityController(IGenericRepository<HealthUnity, int> genericRepository, IMapper mapper) : base(genericRepository, mapper)
        {
  
        }
    }
}
