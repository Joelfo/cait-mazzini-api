using AutoMapper;
using CaitMazziniApp.DTOs;
using CaitMazziniApp.Models.Core;
using CaitMazziniApp.ViewModels;

namespace CaitMazziniApp.Mapper.Profiles.Core
{
    public class PatientProfile : Profile
    {
        public PatientProfile()
        {
            CreateMap<Patient, PatientViewModel>()
               .ForMember(patientDTO => patientDTO.birthCountryId, opt => opt.MapFrom(patient => patient.BirthCountry.Id))
               .ForMember(patientDTO => patientDTO.districtId, opt => opt.MapFrom(patient => patient.District.Id))
               .ForMember(patientDTO => patientDTO.birthplaceId, opt => opt.MapFrom(patient => patient.Birthplace.Id))
               .ForMember(patientDTO => patientDTO.healthUnitytId, opt =>
               {
                   opt.PreCondition(patient => patient.HealthUnity != null);
                   opt.MapFrom(patient => patient.HealthUnity.Id);
               });
            CreateMap<PatientDTO, Patient>()
                .ForPath(patient => patient.BirthCountry.Id, opt => opt.MapFrom(dto => dto.birthCountryId))
                .ForPath(patient => patient.District.Id, opt => opt.MapFrom(dto => dto.districtId))
                .ForPath(patient => patient.Birthplace.Id, opt => opt.MapFrom(dto => dto.birthplaceId))
                .ForMember(patient => patient.HealthUnity, opt =>
                {
                    opt.PreCondition(patientDTO => patientDTO.healthUnitytId != null);
                    opt.MapFrom(patientDTO => new HealthUnity() { Id = patientDTO.healthUnitytId ?? 0 });
                });
        }
    }
}
