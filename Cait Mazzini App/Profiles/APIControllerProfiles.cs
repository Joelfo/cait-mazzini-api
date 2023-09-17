using AutoMapper;
using Cait_Mazzini_App.DTOs;
using Cait_Mazzini_App.Models;
using Cait_Mazzini_App.ViewModels;

namespace Cait_Mazzini_App.Profiles
{
    public class APIControllerProfiles : Profile
    {
        public APIControllerProfiles()
        {
            #region City
            CreateMap<City, CityDTO>();
            CreateMap<CityDTO, City>();
            #endregion

            #region Country
            CreateMap<Country, CountryDTO>();
            CreateMap<CountryDTO, Country>();
            #endregion

            #region District
            CreateMap<District, DistrictDTO>()
                .ForMember(dto => dto.cityId, opt => opt.MapFrom(entity => entity.City.Id));
            CreateMap<DistrictDTO, District>()
                .ForPath(entity => entity.City.Id, opt => opt.MapFrom(dto => dto.cityId));
            #endregion

            #region Patient
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
            #endregion

            #region TrackingAppointmentChart
            CreateMap<TrackingAppointmentChart, TrackingAppointmentChartViewModel>()
                .ForMember(dto => dto.patientId, opt => opt.MapFrom(entity => entity.Patient.Id));
            CreateMap<TrackingAppointmentChartDTO, TrackingAppointmentChart>()
                .ForPath(entity => entity.Patient.Id, opt => opt.MapFrom(dto => dto.patientId));
            #endregion

            #region Country
            CreateMap<CountryDTO, Country>();
            CreateMap<Country, CountryDTO>();
            #endregion

            #region HealthUnity
            CreateMap<HealthUnityDTO, HealthUnity>()
                .ForPath(entity => entity.City.Id, opt => opt.MapFrom(dto => dto.cityId));
            CreateMap<HealthUnity, HealthUnityViewModel>()
                .ForMember(dto => dto.cityId, opt => opt.MapFrom(entity => entity.City.Id));
            #endregion

            #region VitalSignsMeasurement
            CreateMap<VitalSignsMeasurementDTO, VitalSignsMeasurement>()
                .ForPath(entity => entity.Patient.Id, opt => opt.MapFrom(dto => dto.patientId));
            CreateMap<VitalSignsMeasurement, VitalSignsMeasurementViewModel>()
                .ForMember(dto => dto.patientId, opt => opt.MapFrom(entity => entity.Patient.Id));
            #endregion

            #region FederativeUnity
            CreateMap<FederativeUnityDTO, FederativeUnity>()
                .ForPath(entity => entity.Country.Id, opt => opt.MapFrom(dto => dto.countryId));
            CreateMap<FederativeUnity, FederativeUnityViewModel>()
                .ForMember(dto => dto.countryId, opt => opt.MapFrom(entity => entity.Country.Id));
            #endregion

        }
    }
}