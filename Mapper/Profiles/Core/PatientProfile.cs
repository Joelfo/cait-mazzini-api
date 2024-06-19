using AutoMapper;
using CaitMazziniApp.Api.DTOs.Core.Patient;
using CaitMazziniApp.Api.ViewModels.Core.Patient;
using CaitMazziniApp.Models.Core;

namespace CaitMazziniApp.Mapper.Profiles.Core
{
    public class PatientProfile : Profile
    {
        public PatientProfile()
        {
            CreateMap<Patient, PatientViewModel>()
               .ForMember(patientDTO => patientDTO.districtId, opt => opt.MapFrom(patient => (patient.District != null ? patient.District.Id : 0)))
               .ForMember(patientDTO => patientDTO.birthplaceId, opt => opt.MapFrom(patient => patient.Birthplace.Id))
               .ForMember(patientDTO => patientDTO.healthUnityId, opt =>
               {
                   opt.PreCondition(patient => patient.HealthUnity != null);
                   opt.MapFrom(patient => patient.HealthUnity.Id);
               });

            CreateMap<PatientDTO, Patient>()
                .ForPath(patient => patient.District.Id, opt => opt.MapFrom(dto => dto.districtId))
                .ForPath(patient => patient.Birthplace.Id, opt => opt.MapFrom(dto => dto.birthplaceId))
                .ForMember(patient => patient.HealthUnity, opt =>
                {
                    opt.PreCondition(patientDTO => patientDTO.healthUnityId != null);
                    opt.MapFrom(patientDTO => new HealthUnity() { Id = patientDTO.healthUnityId ?? 0 });
                });

            /*CreateMap<Patient, PatientBasicInfoViewModel>()
                .ForAllMembers(opt => opt.MapFrom(entity => new PatientBasicInfoViewModel()
                {
                    hasClinicalHistory = entity.ClinicalHistory != null,
                    hasLifeHabitsInfo = entity.LifeHabitsInfo != null,
                    hasScannedChart = entity.ScannedChartMetadata != null,
                }));*/

            CreateMap<PatientBasicInfo, PatientBasicInfoViewModel>();

            CreateMap<PatientRelationshipsInfo, PatientRelationshipsInfoViewModel>();

            CreateMap<Patient, PatientBasicInfoViewModel>();
        }
    }
}
