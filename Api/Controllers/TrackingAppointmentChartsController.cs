using AutoMapper;
using CaitMazziniApp.Api.Annotations;
using CaitMazziniApp.Api.Controllers.Generic;
using CaitMazziniApp.Database.Repositories.Interfaces;
using CaitMazziniApp.DTOs;
using CaitMazziniApp.Enums;
using CaitMazziniApp.Models.Charts;
using CaitMazziniApp.ViewModels;
using CaitMazziniApp.ViewModels.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace CaitMazziniApp.Controllers
{
    [Route("[controller]")]
    public class TrackingAppointmentChartsController : APIResourceController<TrackingAppointmentChartDTO, TrackingAppointmentChartViewModel, TrackingAppointmentChart, ITrackingAppointmentChartRepository>
    {
        public TrackingAppointmentChartsController(ITrackingAppointmentChartRepository genericRepository, IMapper mapper) : base(genericRepository, mapper)
        {

        }

        [HttpPost]
        [Authorize(Roles = "Admin, Nurse, Physician, Pharmaceutical")]
        public async override Task<IActionResult> Create([FromBody] TrackingAppointmentChartDTO dto) {
            return await base.Create(dto);
        }

        public async override Task<IActionResult> Update([FromRoute]int id, [FromBody] TrackingAppointmentChartDTO dto)
        {
            return new ForbidResult();
        }

        [HttpGet("~/patients/{patientId}/TrackingAppointmentCharts/ByType")]
        public async Task<IActionResult> AllByPatientAndType([FromRoute] int patientId, [FromQuery] ETrackingAppointmentChartType type, [FromQuery] int? skip, [FromQuery] int? take)
        {
            var entities = await _repository.AllByPatientAndType(patientId, type, skip, take);
            var viewModels = _mapper.Map<IList<TrackingAppointmentChartViewModel>>(entities);
            return Ok(viewModels);
        }

        [HttpGet("~/patients/{patientId}/TrackingAppointmentCharts/BasicInfo/ByType")]
        public async Task<IActionResult> AllBasicInfoByPatientAndType([FromRoute] int patientId, [FromQuery] ETrackingAppointmentChartType type, [FromQuery] int? skip, [FromQuery] int? take)
        {
            var entities = await _repository.AllBasicInfoByPatientAndType(patientId, type, skip, take);
            var viewModels = _mapper.Map<IList<TrackingAppointmentChartBasicInfoViewModel>>(entities);
            return Ok(viewModels);
        }

        [HttpGet("~/Patients/{patientId}/TrackingAppointmentCharts/BasicInfo")]
        public async Task<IActionResult> AllBasicInfoByPatient([FromRoute] int patientId, [FromQuery] int? skip, [FromQuery] int? take)
        {
            var entities = await _repository.AllBasicInfoByPatient(patientId, skip, take);
            var viewModels = _mapper.Map<IList<TrackingAppointmentChartBasicInfoViewModel>>(entities);
            return Ok(viewModels);
        }
    }
}
