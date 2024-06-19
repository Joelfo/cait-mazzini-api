using AutoMapper;
using CaitMazziniApp.Api.DTOs.FirstAppointments;
using CaitMazziniApp.Api.ViewModels.FirstAppointments;
using CaitMazziniApp.Models.Core;
using CaitMazziniApp.Models.FirstAppointments;

namespace CaitMazziniApp.Mapper.Profiles.FirstAppointments
{
    public class FirstMedicalAppointmentProfile : Profile
    {
        public FirstMedicalAppointmentProfile()
        {
            CreateMap<FirstMedicalAppointmentChart, FirstMedicalAppointmentChartViewModel>();
            CreateMap<FirstMedicalAppointmentChartDTO, FirstMedicalAppointmentChart>()
                .ForMember(x => x.Creator, opt => opt.MapFrom(x => new User { Id = x.creatorId }))
                .ForMember(entity => entity.Patient, opt => opt.MapFrom(dto => new Patient { Id = dto.patientId }))
                ;
        }
    }
}
