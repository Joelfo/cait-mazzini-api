using AutoMapper;
using CaitMazziniApp.Database.Repositories.Interfaces;
using CaitMazziniApp.DTOs;
using CaitMazziniApp.Models.Charts;
using CaitMazziniApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CaitMazziniApp.Controllers
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
            var vitalSignsMeasurements = (await _vitalSignsMeasurementRepository.AllByPatient(patientId)).ToList();
            var viewModels = _mapper.Map<List<VitalSignsMeasurement>, List<VitalSignsMeasurementViewModel>>(vitalSignsMeasurements);
            return Ok(viewModels);
        }
    }
}
