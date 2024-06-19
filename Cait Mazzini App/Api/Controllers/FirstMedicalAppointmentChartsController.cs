using AutoMapper;
using CaitMazziniApp.Api.Controllers.Generic;
using CaitMazziniApp.Api.DTOs.FirstAppointments;
using CaitMazziniApp.Api.ViewModels.FirstAppointments;
using CaitMazziniApp.Database.Repositories.Interfaces;
using CaitMazziniApp.Models.FirstAppointments;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace CaitMazziniApp.Api.Controllers
{
    public class FirstMedicalAppointmentChartsController : APIResourceController<FirstMedicalAppointmentChartDTO, FirstMedicalAppointmentChartViewModel, FirstMedicalAppointmentChart, IFirstMedicalAppointmentChartRepository>
    {
        public FirstMedicalAppointmentChartsController(IMapper mapper, IFirstMedicalAppointmentChartRepository repository) : base(repository, mapper)
        {
            
        }

        [HttpGet("~/Patients/{patientId}/FirstMedicalAppointmentChart")]
        public async Task<IActionResult> GetByPatient([FromRoute]int patientId)
        {
            var entity = await _repository.GetByPatient(patientId);
            var vm = _mapper.Map<FirstMedicalAppointmentChartViewModel>(entity);

            return Ok(vm);
        }
    }
}
