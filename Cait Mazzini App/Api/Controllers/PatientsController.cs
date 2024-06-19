using AutoMapper;
using CaitMazziniApp.Api.Controllers.Generic;
using CaitMazziniApp.Api.DTOs.Core.Patient;
using CaitMazziniApp.Api.DTOs.PatientClinicalHistory;
using CaitMazziniApp.Api.ViewModels.Core.Patient;
using CaitMazziniApp.Api.ViewModels.PatientLifeHabits;
using CaitMazziniApp.Database.Repositories.Interfaces;
using CaitMazziniApp.Models.Core;
using CaitMazziniApp.Models.PatientClinicalHistory;
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
            var entities = await _repository.AllBasicInfoByName(name);
            var dtos = _mapper.Map<IList<PatientBasicInfo>, IList<PatientBasicInfoViewModel>>(entities);
            return Ok(dtos);
        }

        [HttpGet("{patientId}/Relationships")]
        public async Task<IActionResult> ShowRelationshipsInfo([FromRoute]int patientId)
        {
            var relationshipsInfo = await _repository.ShowRelationshipsInfo(patientId);
            var viewModel = _mapper.Map<PatientRelationshipsInfoViewModel>(relationshipsInfo);

            return Ok(viewModel);
             
        }

        public override async Task<IActionResult> All([FromQuery] int? skip, [FromQuery] int? take)
        {
            IList<Patient> entities;
            entities = await _repository.All(skip, take);
            var dtos = entities.Select(entity => _mapper.Map<PatientViewModel>(entity));
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
