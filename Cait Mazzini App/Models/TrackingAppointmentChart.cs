using Cait_Mazzini_App.Enums;
using Cait_Mazzini_App.Models.Base;

namespace Cait_Mazzini_App.Models
{
    public class TrackingAppointmentChart : BaseModel
    {
        public ETrackingAppointmentChartType Type { get; set; }

        public string Schema { get; set; } = string.Empty;

        public string Evolution { get; set; } = string.Empty;

        public string Conduct { get; set; } = string.Empty;

        public DateOnly Date { get; set; }

        public virtual Patient Patient { get; set; }
    }
}
