using AutoMapper;
using CaitMazziniApp.Api.DTOs.PatientLifeHabits;
using CaitMazziniApp.Api.ViewModels.PatientLifeHabits;
using CaitMazziniApp.Controllers;
using CaitMazziniApp.Database.Repositories.EFCore;
using CaitMazziniApp.Database.Repositories.Interfaces;
using CaitMazziniApp.Models.PatientLifeHabits;
using System.Security.Cryptography.X509Certificates;

namespace CaitMazziniApp.Api.Controllers
{
    public class PhysicalActivitiesController : APIResourceController<PhysicalActivityDTO, PhysicalActivityViewModel, PhysicalActivity, IGenericRepository<PhysicalActivity, int>>
    {
        public PhysicalActivitiesController(IGenericRepository<PhysicalActivity, int> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
