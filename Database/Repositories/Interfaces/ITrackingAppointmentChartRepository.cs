using CaitMazziniApp.Enums;
using CaitMazziniApp.Models.Charts;
using CaitMazziniApp.Models.Charts.Utils;

namespace CaitMazziniApp.Database.Repositories.Interfaces
{
    public interface ITrackingAppointmentChartRepository : IGenericRepository<TrackingAppointmentChart, int>
    {
        Task<IList<TrackingAppointmentChart>> AllByPatientAndType(int patientId, ETrackingAppointmentChartType type, int? skip, int? take);

        Task<IList<TrackingAppointmentChartBasicInfo>> AllBasicInfoByPatientAndType(int patientId, ETrackingAppointmentChartType type, int? skip, int? take);
    
        Task<IList<TrackingAppointmentChartBasicInfo>> AllBasicInfoByPatient(int patientId, int? skip, int? take);
    }
}