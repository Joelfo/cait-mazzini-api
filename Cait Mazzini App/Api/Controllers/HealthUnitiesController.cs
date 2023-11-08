using AutoMapper;
using CaitMazziniApp.Database.Repositories.Interfaces;
using CaitMazziniApp.DTOs;
using CaitMazziniApp.Models.Core;
using CaitMazziniApp.ViewModels;
using Microsoft.AspNetCore.Components;
using System.Security.Cryptography.X509Certificates;

namespace CaitMazziniApp.Controllers
{
    public class HealthUnitiesController : APIResourceController<HealthUnityDTO, HealthUnityViewModel, HealthUnity, IGenericRepository<HealthUnity, int>>
    {
        public HealthUnitiesController(IGenericRepository<HealthUnity, int> genericRepository, IMapper mapper) : base(genericRepository, mapper)
        {
  
        }
    }
}
