using AutoMapper;
using CaitMazziniApp.Api.Controllers.Generic;
using CaitMazziniApp.Api.DTOs.PatientClinicalHistory;
using CaitMazziniApp.Api.ViewModels.PatientClinicalHistory;
using CaitMazziniApp.Database.Repositories.Interfaces;
using CaitMazziniApp.Models.PatientClinicalHistory;
using Microsoft.AspNetCore.Mvc;

namespace CaitMazziniApp.Api.Controllers
{
    public class ClinicalHistoriesController : APIResourceController<ClinicalHistoryDTO, ClinicalHistoryViewModel, ClinicalHistory, IGenericRepository<ClinicalHistory, int>>
    {
        public ClinicalHistoriesController(IGenericRepository<ClinicalHistory, int> repository, IMapper mapper) : base(repository, mapper)
        {
            
        }

        [HttpGet("{id}/Immunizations")]
        public async Task<IActionResult> GetImmunizations([FromRoute] int id)
        {
            var clinicalHistory = await _repository.Find(id);

            if (clinicalHistory == null)
            {
                return NotFound("Clinical history not found");
            }

            var immunizations = clinicalHistory.Immunizations;

            var viewModels = _mapper.Map<IList<Immunization>, IList<ImmunizationViewModel>>(immunizations);
            return Ok(viewModels);
        }

        [HttpGet("{id}/DatedImmunizations")]
        public async Task<IActionResult> GetDatedImmunizations([FromRoute] int id)
        {
            var clinicalHistory = await _repository.Find(id);

            if (clinicalHistory == null)
            {
                return NotFound("Clinical history not found");
            }

            var clinicalHistoryHasDatedImmunizations = clinicalHistory.ClinicalHistoryHasDatedImmunizations.ToList();

            var viewModels = _mapper.Map<List<ClinicalHistoryHasDatedImmunization>, List<ClinicalHistoryHasDatedImmunizationViewModel>>(clinicalHistoryHasDatedImmunizations);
            return Ok(viewModels);
        }

        [HttpGet("{id}/PreviousDeseases")]
        public async Task<IActionResult> GetPreviousDeseases([FromRoute] int id)
        {
            var clinicalHistory = await _repository.Find(id);

            if (clinicalHistory == null)
            {
                return NotFound("Clinical history not found");
            }

            var previousDeseases = clinicalHistory.PreviousDeseases.ToList();

            var viewModels = _mapper.Map<List<Desease>, List<DeseaseViewModel>>(previousDeseases);
            return Ok(viewModels);
        }

    }
}
