using CaitMazziniApp.Enums;
using CaitMazziniApp.Models.Base;
using CaitMazziniApp.Models.Core;

namespace CaitMazziniApp.Models.Charts
{
    public class TrackingAppointmentChart : IId
    {
        public int Id { get; set; }

        public ETrackingAppointmentChartType Type { get; set; }

        public string Schema { get; set; } = string.Empty;

        public string Evolution { get; set; } = string.Empty;

        public string Conduct { get; set; } = string.Empty;

        public DateOnly Date { get; set; }

        public virtual Patient Patient { get; set; }
    }
}
