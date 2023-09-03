using Cait_Mazzini_App.Enums;

namespace Cait_Mazzini_App.DTOs
{
    public class TrackingAppointmentChartDTO : BaseModelDTO
    {
        public ETrackingAppointmentChartType type { get; set; }

        public string schema { get; set; } = string.Empty;

        public string evolution { get; set; } = string.Empty;

        public string conduct { get; set; } = string.Empty;

        public DateOnly date { get; set; }

        public int patientId { get; set; }
    }
}
