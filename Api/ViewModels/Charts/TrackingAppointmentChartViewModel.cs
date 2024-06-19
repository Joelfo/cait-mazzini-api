using CaitMazziniApp.Enums;
using System.ComponentModel.DataAnnotations;

namespace CaitMazziniApp.ViewModels
{
    public class TrackingAppointmentChartViewModel
    {
        public ETrackingAppointmentChartType type { get; set; }

        public string schema { get; set; } = string.Empty;

        public string evolution { get; set; } = string.Empty;

        public string conduct { get; set; } = string.Empty;

        public DateOnly date { get; set; }

        public int patientId { get; set; }

        public int id { get; set; }

        public int creatorId { get; set; }
    }
}
