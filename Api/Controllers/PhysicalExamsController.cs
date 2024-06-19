using AutoMapper;
using CaitMazziniApp.Api.Controllers.Generic;
using CaitMazziniApp.Api.DTOs.PatientClinicalHistory;
using CaitMazziniApp.Api.ViewModels.PatientClinicalHistory;
using CaitMazziniApp.Database.Repositories.Interfaces;
using CaitMazziniApp.Models.PatientClinicalHistory;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace CaitMazziniApp.Api.Controllers
{
    public class PhysicalExamsController : APIResourceController<PhysicalExamDTO, PhysicalExamViewModel, PhysicalExam, IPhysicalExamRepository>
    {
        public PhysicalExamsController(IPhysicalExamRepository repository, IMapper mapper) : base(repository, mapper)
        { 
        }

        [HttpGet("~/Patients/{patientId}/PhysicalExams")]
        public async Task<IActionResult> GetByPatient(int patientId)
        {
            var entities = await _repository.GetByPatient(patientId);
            var viewModels = _mapper.Map<IList<PhysicalExam>, List<PhysicalExamViewModel>>(entities);

            return Ok(viewModels);
        }   
    }
}
