using AutoMapper;
using Cait_Mazzini_App.Database.Repositories.Interfaces;
using Cait_Mazzini_App.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cait_Mazzini_App.Controllers
{
    [Route("[controller]")]
    public class TrackingAppointmentChartController
    {
        public TrackingAppointmentChartController(IGenericRepository<TrackingAppointmentChart, int> genericRepository, IMapper mapper)
        {
            
        }
    }
}
