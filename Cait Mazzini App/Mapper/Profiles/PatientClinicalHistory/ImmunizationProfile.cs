using AutoMapper;
using CaitMazziniApp.Api.DTOs.PatientClinicalHistory;
using CaitMazziniApp.Api.ViewModels.PatientClinicalHistory;
using CaitMazziniApp.Models.PatientClinicalHistory;

namespace CaitMazziniApp.Mapper.Profiles.PatientClinicalHistory
{
    public class ImmunizationProfile : Profile
    {
        public ImmunizationProfile() 
        { 
            CreateMap<Immunization, ImmunizationViewModel>();
            CreateMap<ImmunizationDTO, Immunization>();
        }
    }
}
