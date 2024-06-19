using AutoMapper;
using CaitMazziniApp.Api.DTOs.Support;
using CaitMazziniApp.Api.ViewModels.Support;
using CaitMazziniApp.Database.Repositories.Interfaces;
using CaitMazziniApp.Models.Support;
using Microsoft.AspNetCore.Mvc;

namespace CaitMazziniApp.Api.Controllers.Support
{
    [Route("PatientsAppointmentLine")]
    public class PatientsAppointmentLineController : ControllerBase
    {
        public readonly IGenericRepository<PatientsAppointmentLineEntry, int> _repository;
        public readonly IMapper _mapper;

        public PatientsAppointmentLineController(IGenericRepository<PatientsAppointmentLineEntry, int> repository, IMapper mapper) 
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> AddEntry([FromBody] PatientsAppointmentLineEntryDTO dto)
        {
            if ((await _repository.Find(dto.patientId)) != null){
                return BadRequest("An entry for this patient already exists. Delete it if you want to add another.");
            }
            
            var entity = _mapper.Map<PatientsAppointmentLineEntry>(dto);

            await _repository.Create(entity);
            return Ok();
        }

        [HttpDelete("{patientId}")]
        public async Task<IActionResult> RemoveEntry([FromRoute]int patientId) 
        {
            var entry = await _repository.Find(patientId);

            if (entry != null)
            {
                await _repository.Delete(patientId);
            }

            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetLine()
        {
            
            var entries = await _repository.All(null, null);
            var viewModels = _mapper.Map<List<PatientsAppointmentLineEntryViewModel>>(entries);
            return Ok(viewModels);
        }
    }
}
