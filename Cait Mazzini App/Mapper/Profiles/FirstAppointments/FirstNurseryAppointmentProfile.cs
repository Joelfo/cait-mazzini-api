using AutoMapper;
using CaitMazziniApp.Api.DTOs.FirstAppointments;
using CaitMazziniApp.Api.ViewModels.FirstAppointments;
using CaitMazziniApp.Models.FirstAppointments;

namespace CaitMazziniApp.Mapper.Profiles.FirstAppointments
{
    public class FirstNurseryAppointmentProfile : Profile
    {
        public FirstNurseryAppointmentProfile() 
        {
            CreateMap<FirstNurseryAppointmentDTO, FirstNurseryAppointment>();
            CreateMap<FirstNurseryAppointment, FirstNurseryAppointmentViewModel>();
        }
    }
}
