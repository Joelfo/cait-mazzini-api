using Cait_Mazzini_App.Enums;
using Cait_Mazzini_App.Models;
using Cait_Mazzini_App.Models.Utils;

namespace Cait_Mazzini_App.Database.Repositories.Interfaces
{
    public interface ITrackingAppointmentChartRepository : IGenericRepository<TrackingAppointmentChart, int>
    {
        IList<TrackingAppointmentChart> AllByPatientAndType(int patientId, ETrackingAppointmentChartType type, int? skip, int? take);

        IList<TrackingAppointmentChartBasicInfo> AllBasicInfoByPatientAndType(int patientId, ETrackingAppointmentChartType type, int? skip, int? take);
    }
}
