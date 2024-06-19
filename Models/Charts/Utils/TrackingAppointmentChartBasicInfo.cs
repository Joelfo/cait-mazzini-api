using CaitMazziniApp.Enums;
using CaitMazziniApp.Models.Base;

namespace CaitMazziniApp.Models.Charts.Utils
{
    public class TrackingAppointmentChartBasicInfo : IId
    {
        public int Id { get; set; }

        public DateOnly Date { get; set; }

        public ETrackingAppointmentChartType Type { get; set; }
    }
}
