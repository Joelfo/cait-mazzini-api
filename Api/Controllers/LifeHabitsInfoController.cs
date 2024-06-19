using AutoMapper;
using CaitMazziniApp.Api.Controllers.Generic;
using CaitMazziniApp.Api.DTOs.PatientClinicalHistory;
using CaitMazziniApp.Api.DTOs.PatientLifeHabits;
using CaitMazziniApp.Api.ViewModels.PatientLifeHabits;
using CaitMazziniApp.Database.Repositories.Interfaces;
using CaitMazziniApp.Models.PatientLifeHabits;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace CaitMazziniApp.Api.Controllers
{
    public class LifeHabitsInfoController : APIResourceController<LifeHabitsInfoDTO, LifeHabitsInfoVIewModel, LifeHabitsInfo, IGenericRepository<LifeHabitsInfo, int>>
    {
        public LifeHabitsInfoController(IGenericRepository<LifeHabitsInfo, int> repository, IMapper mapper) : base(repository, mapper)
        {
            
        }

        [HttpGet("{id}/PhysicalActivities")]
        public async Task<IActionResult> GetPhysicalActivities(int id)
        {
            var lifeHabitsInfo = await _repository.Find(id);

            if (lifeHabitsInfo == null)
            {
                return NotFound("LifeHabitsInfo not found");
            }

            var physicalActivities = lifeHabitsInfo.PhysicalActivities;

            var viewModels = _mapper.Map<IList<PhysicalActivity>, IList<PhysicalActivityViewModel>>(physicalActivities);
            return Ok(viewModels);
        }

        [HttpGet("{id}/ContraceptiveMethods")]
        public async Task<IActionResult> GetContraceptiveMethods(int id)
        {
            var lifeHabitsInfo = await _repository.Find(id);

            if (lifeHabitsInfo == null)
            {
                return NotFound("LifeHabitsInfo not found");
            }

            var contraceptiveMethods = lifeHabitsInfo.ContraceptiveMethods;

            var viewModels = _mapper.Map<IList<ContraceptiveMethod>, IList<ContraceptiveMethodViewModel>>(contraceptiveMethods);
            return Ok(viewModels);
        }
    }
}
