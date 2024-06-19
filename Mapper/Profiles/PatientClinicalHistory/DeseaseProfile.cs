using AutoMapper;
using CaitMazziniApp.Api.DTOs.PatientClinicalHistory;
using CaitMazziniApp.Api.ViewModels.PatientClinicalHistory;
using CaitMazziniApp.Models.PatientClinicalHistory;

namespace CaitMazziniApp.Mapper.Profiles.PatientClinicalHistory
{
    public class DeseaseProfile : Profile
    {
        public DeseaseProfile()
        {
            CreateMap<Desease, DeseaseViewModel>();
            CreateMap<DeseaseDTO, Desease>();
        }
    }
}
