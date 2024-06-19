using AutoMapper;
using CaitMazziniApp.Api.DTOs.Support;
using CaitMazziniApp.Api.ViewModels.Support;
using CaitMazziniApp.Models.Support;

namespace CaitMazziniApp.Mapper.Profiles.Support
{
    public class PatientsAppointmentLineEntryProfile : Profile
    {
        public PatientsAppointmentLineEntryProfile()
        {
            CreateMap<PatientsAppointmentLineEntry, PatientsAppointmentLineEntryViewModel>();
            CreateMap<PatientsAppointmentLineEntryDTO, PatientsAppointmentLineEntry>();
        }
    }
}
