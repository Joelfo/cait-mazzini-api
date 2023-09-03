using AutoMapper;
using Cait_Mazzini_App.DTOs;
using Cait_Mazzini_App.Models;

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
            CreateMap<Patient, PatientDTO>()
                .ForMember(patientDTO => patientDTO.birthCountryId, opt => opt.MapFrom(patient => patient.BirthCountry.Id))
                .ForMember(patientDTO => patientDTO.districtId, opt => opt.MapFrom(patient => patient.District.Id))
                .ForMember(patientDTO => patientDTO.healthUnitytId, opt =>
                {
                    opt.PreCondition(patient => patient.HealthUnity != null);
                    opt.MapFrom(patient => patient.HealthUnity.Id);
                });
            CreateMap<PatientDTO, Patient>()
                .ForPath(patient => patient.BirthCountry.Id, opt => opt.MapFrom(dto => dto.birthCountryId))
                .ForPath(patient => patient.District.Id, opt => opt.MapFrom(dto => dto.districtId))
                .ForMember(patient => patient.HealthUnity, opt =>
                {
                    opt.PreCondition(patientDTO => patientDTO.healthUnitytId != null);
                    opt.MapFrom(patientDTO => new HealthUnity() { Id = patientDTO.healthUnitytId ?? 0 });
                });
            #endregion

            #region TrackingAppointmentChart
            CreateMap<TrackingAppointmentChart, TrackingAppointmentChartDTO>();
            CreateMap<TrackingAppointmentChartDTO, TrackingAppointmentChart>();
            #endregion

            #region Country
            CreateMap<CountryDTO, Country>();
            CreateMap<Country, CountryDTO>();
            #endregion

            #region HealthUnity
            CreateMap<HealthUnityDTO, HealthUnity>()
                .ForPath(entity => entity.City.Id, opt => opt.MapFrom(dto => dto.CityId));
            CreateMap<HealthUnity, HealthUnityDTO>()
                .ForMember(dto => dto.CityId, opt => opt.MapFrom(entity => entity.City.Id));
            #endregion

        }
    }
}
