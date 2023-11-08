using AutoMapper;
using CaitMazziniApp.Api.DTOs.PatientClinicalHistory;
using CaitMazziniApp.Api.ViewModels.PatientLifeHabits;
using CaitMazziniApp.Database.Repositories.Interfaces;
using CaitMazziniApp.DTOs;
using CaitMazziniApp.Models.Core;
using CaitMazziniApp.Models.PatientClinicalHistory;
using CaitMazziniApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace CaitMazziniApp.Controllers
{
    public class PatientsController : APIResourceController<PatientDTO, PatientViewModel, Patient, IPatientRepository>
    {
        public PatientsController(IPatientRepository repository, IMapper mapper) : base(repository, mapper) 
        {
        }

        [HttpGet("ByName")]
        public async Task<IActionResult> AllByName(string name)
        {
            var entities = await _repository.AllByName(name);
            var dtos = _mapper.Map<IList<Patient>, IList<PatientDTO>>(entities);
            return Ok(dtos);
        }

        [HttpGet("{patientId}/ClinicalHistory")]
        public async Task<IActionResult> GetClinicalHistory([FromRoute] int patientId)
        {
            var patient = await _repository.Find(patientId);

            if (patient == null)
            {
                return NotFound("Patient not found");
            }

            var clinicalHistory = patient.ClinicalHistory;

            if (clinicalHistory == null)
            {
                return NotFound("Patient doesn't have a clinical history.");
            }

            var viewModel = _mapper.Map<ClinicalHistory, ClinicalHistoryViewModel>(clinicalHistory);
            return Ok(viewModel);
        }

        [HttpGet("{patientId}/LifeHabitsInfo")]
        public async Task<IActionResult> GetLifeHabitsInfo([FromRoute] int patientId)
        {
            var patient = await _repository.Find(patientId);

            if (patient == null)
            {
                return NotFound("Patient not found");
            }
            
            var lifeHabitsInfo = patient.LifeHabitsInfo;

            if (lifeHabitsInfo == null)
            {
                return NotFound("Patient doesn't have a Life Habits Info");
            }

            var viewModel = _mapper.Map<LifeHabitsInfoVIewModel>(lifeHabitsInfo); ;
            return Ok(viewModel);
        }
    }
}
