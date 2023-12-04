using CaitMazziniApp.Database.Repositories.EFCore;
using CaitMazziniApp.Database.Repositories.Interfaces;

namespace CaitMazziniApp.ServiceCollectionExtensions
{
    public static class DependencyInjectionGroup
    {
        public static IServiceCollection AddDependencyInjectionGroup(this IServiceCollection services)
        {

            #region Services

            #endregion

            #region Repositories
                services.AddScoped(typeof(IGenericRepository<,>), typeof(EFCoreGenericRepository<,>));
                services.AddScoped<IDistrictRepository, EFCoreDistrictRepository>();
                services.AddScoped<IVitalSignsMeasurementRepository, EFCoreVitalSignsMeasurementRepository>();
                services.AddScoped<IFederativeUnityRepository, EFCoreFederativeUnityRepository>();
                services.AddScoped<IPatientRepository, EFCorePatientRepository>();
                services.AddScoped<ITrackingAppointmentChartRepository, EFCoreTrackingAppointmentChartRerpository>();
                services.AddScoped<IFirstNurseryAppointmentRepository, EFCoreFirstNurseryAppointmentRepository>();
                services.AddScoped(typeof(IComplementaryExamRepository<>), typeof(EFCoreComplementaryExamRepository<>));
            #endregion

            return services;
        }
    }
}
