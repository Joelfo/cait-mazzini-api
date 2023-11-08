using AutoMapper;
using CaitMazziniApp.Api.DTOs.PatientClinicalHistory;
using CaitMazziniApp.Api.ViewModels.PatientLifeHabits;
using CaitMazziniApp.Controllers;
using CaitMazziniApp.Database.Repositories.Interfaces;
using CaitMazziniApp.Models.PatientLifeHabits;

namespace CaitMazziniApp.Api.Controllers
{
    public class ContraceptiveMethodsController : APIResourceController<ContraceptiveMethodDTO, ContraceptiveMethodViewModel, ContraceptiveMethod, IGenericRepository<ContraceptiveMethod, int>>
    {
        public ContraceptiveMethodsController(IGenericRepository<ContraceptiveMethod, int> repository, IMapper mapper) : base(repository, mapper)
        {
            
        }
    }
}
