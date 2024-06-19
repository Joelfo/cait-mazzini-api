using AutoMapper;
using CaitMazziniApp.DTOs;
using CaitMazziniApp.Models.Charts;
using CaitMazziniApp.Models.Charts.Utils;
using CaitMazziniApp.Models.Core;
using CaitMazziniApp.ViewModels;
using CaitMazziniApp.ViewModels.Utils;

namespace CaitMazziniApp.Mapper.Profiles
{
    public class APIControllerProfiles : Profile
    {
        public APIControllerProfiles()
        {

            #region TrackingAppointmentChart
            CreateMap<TrackingAppointmentChart, TrackingAppointmentChartViewModel>()
                .ForMember(dto => dto.patientId, opt => opt.MapFrom(entity => entity.Patient.Id));
            CreateMap<TrackingAppointmentChartDTO, TrackingAppointmentChart>()
                .ForPath(entity => entity.Patient.Id, opt => opt.MapFrom(dto => dto.patientId));
            CreateMap<TrackingAppointmentChartBasicInfo, TrackingAppointmentChartBasicInfoViewModel>();
            #endregion

            #region Country
            CreateMap<CountryDTO, Country>();
            CreateMap<Country, CountryDTO>();
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