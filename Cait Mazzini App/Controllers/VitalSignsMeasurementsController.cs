using AutoMapper;
using Cait_Mazzini_App.Database.Repositories.Interfaces;
using Cait_Mazzini_App.DTOs;
using Cait_Mazzini_App.Models;
using Cait_Mazzini_App.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Cait_Mazzini_App.Controllers
{
    [Route("[controller]")]
    public class VitalSignsMeasurementsController : APIResourceController<VitalSignsMeasurementDTO, VitalSignsMeasurementViewModel, VitalSignsMeasurement, IGenericRepository<VitalSignsMeasurement, int>>
    {
        private readonly IVitalSignsMeasurementRepository _vitalSignsMeasurementRepository;
        public VitalSignsMeasurementsController (IVitalSignsMeasurementRepository repository, IMapper mapper) 
            : base(repository, mapper) 
        { 
            _vitalSignsMeasurementRepository = repository;
        }

        [HttpGet("~/Patients/{patientId}/VitalSignsMeasurements")]
        public async Task<IActionResult> GetAllByPatient([FromRoute] int patientId)
        {
            IList<VitalSignsMeasurement> vitalSignsMeasurements = _vitalSignsMeasurementRepository.AllByPatient(patientId);
            IList<VitalSignsMeasurementDTO> dtos = vitalSignsMeasurements.Select(entity => _mapper.Map<VitalSignsMeasurementDTO>(entity)).ToList();
            return Ok(dtos);
        }
    }
}
