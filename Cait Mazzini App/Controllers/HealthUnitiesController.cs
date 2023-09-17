using AutoMapper;
using Cait_Mazzini_App.Database.Repositories.Interfaces;
using Cait_Mazzini_App.DTOs;
using Cait_Mazzini_App.Models;
using Cait_Mazzini_App.ViewModels;
using Microsoft.AspNetCore.Components;
using System.Security.Cryptography.X509Certificates;

namespace Cait_Mazzini_App.Controllers
{
    public class HealthUnitiesController : APIResourceController<HealthUnityDTO, HealthUnityViewModel, HealthUnity, IGenericRepository<HealthUnity, int>>
    {
        public HealthUnitiesController(IGenericRepository<HealthUnity, int> genericRepository, IMapper mapper) : base(genericRepository, mapper)
        {
  
        }
    }
}
