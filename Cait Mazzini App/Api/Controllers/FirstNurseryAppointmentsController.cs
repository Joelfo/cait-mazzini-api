using AutoMapper;
using CaitMazziniApp.Api.Controllers.Generic;
using CaitMazziniApp.Api.DTOs.FirstAppointments;
using CaitMazziniApp.Api.ViewModels.FirstAppointments;
using CaitMazziniApp.Database.Repositories.Interfaces;
using CaitMazziniApp.Models.FirstAppointments;
using Microsoft.AspNetCore.Mvc;

namespace CaitMazziniApp.Api.Controllers
{
    public class FirstNurseryAppointmentsController : APIResourceController<FirstNurseryAppointmentDTO, FirstNurseryAppointmentViewModel, FirstNurseryAppointment, IFirstNurseryAppointmentRepository>
    {
        public FirstNurseryAppointmentsController(IFirstNurseryAppointmentRepository repository, IMapper mapper) : base(repository, mapper)
        {
                
        }

        [HttpGet("/Patients/{patientId}/FirstNurseryAppointment")]
        public async Task<IActionResult> GetByPatient([FromRoute] int patientId)
        {
            var entity = await _repository.GetByPatient(patientId);
            var viewModel = _mapper.Map<FirstNurseryAppointmentViewModel>(entity);
            return Ok(viewModel);
        }
    }
}
