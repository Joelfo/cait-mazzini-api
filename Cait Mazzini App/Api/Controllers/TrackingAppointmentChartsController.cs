using AutoMapper;
using CaitMazziniApp.Database.Repositories.Interfaces;
using CaitMazziniApp.DTOs;
using CaitMazziniApp.Enums;
using CaitMazziniApp.Models.Charts;
using CaitMazziniApp.ViewModels;
using CaitMazziniApp.ViewModels.Utils;
using Microsoft.AspNetCore.Mvc;

namespace CaitMazziniApp.Controllers
{
    [Route("[controller]")]
    public class TrackingAppointmentChartsController : APIResourceController<TrackingAppointmentChartDTO, TrackingAppointmentChartViewModel, TrackingAppointmentChart, ITrackingAppointmentChartRepository>
    {
        public TrackingAppointmentChartsController(ITrackingAppointmentChartRepository genericRepository, IMapper mapper) : base(genericRepository, mapper)
        {

        }

        [HttpGet("~/patients/{patientId}/TrackingAppointmentCharts/ByType")]
        public async Task<IActionResult> AllByPatientAndType([FromRoute] int patientId, [FromQuery] ETrackingAppointmentChartType type, [FromQuery] int? skip, [FromQuery] int? take)
        {
            var entities = _repository.AllByPatientAndType(patientId, type, skip, take);
            var viewModels = _mapper.Map<IList<TrackingAppointmentChartViewModel>>(entities);
            return Ok(viewModels);
        }

        [HttpGet("~/patients/{patientId}/TrackingAppointmentCharts/BasicInfo/ByType")]
        public async Task<IActionResult> AllBasicInfoByPatientAndType([FromRoute] int patientId, [FromQuery] ETrackingAppointmentChartType type, [FromQuery] int? skip, [FromQuery] int? take)
        {
            var entities = _repository.AllBasicInfoByPatientAndType(patientId, type, skip, take);
            var viewModels = _mapper.Map<IList<TrackingAppointmentChartBasicInfoViewModel>>(entities);
            return Ok(viewModels);
        }
    }
}
