using Cait_Mazzini_App.Enums;
using System.ComponentModel.DataAnnotations;

namespace Cait_Mazzini_App.ViewModels
{
    public class TrackingAppointmentChartViewModel
    {
        public ETrackingAppointmentChartType type { get; set; }

        public string schema { get; set; } = string.Empty;

        public string evolution { get; set; } = string.Empty;

        public string conduct { get; set; } = string.Empty;

        public DateOnly date { get; set; }

        public int patientId { get; set; }
    }
}
