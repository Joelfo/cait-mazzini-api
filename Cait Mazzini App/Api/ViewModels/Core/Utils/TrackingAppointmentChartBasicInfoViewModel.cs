using CaitMazziniApp.Enums;

namespace CaitMazziniApp.ViewModels.Utils
{
    public class TrackingAppointmentChartBasicInfoViewModel
    {
        public int id { get; set; }

        public DateOnly date {  get; set; }

        public ETrackingAppointmentChartType type { get; set; }
    }
}
