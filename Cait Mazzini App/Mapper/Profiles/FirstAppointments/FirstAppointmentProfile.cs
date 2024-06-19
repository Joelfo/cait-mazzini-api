using AutoMapper;
using CaitMazziniApp.Api.DTOs.FirstAppointments;
using CaitMazziniApp.Api.ViewModels.FirstAppointments;
using CaitMazziniApp.Models.Core;
using CaitMazziniApp.Models.FirstAppointments;

namespace CaitMazziniApp.Mapper.Profiles.FirstAppointments
{
    public class FirstAppointmentProfile : Profile
    {
        public FirstAppointmentProfile()
        {
            CreateMap<FirstAppointmentChart, FirstAppointmentViewModel>().ForMember(x => x.creatorId, opt => opt.MapFrom(x => x.Creator.Id));
            CreateMap<FirstAppointmentDTO, FirstAppointmentChart>().ForMember(x => x.Creator, opt => opt.MapFrom(x => new User { Id = x.creatorId }));
        }
    }
}
