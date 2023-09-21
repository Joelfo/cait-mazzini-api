using Cait_Mazzini_App.Enums;
using System.ComponentModel.DataAnnotations;

namespace Cait_Mazzini_App.DTOs
{
    public class TrackingAppointmentChartDTO
    {
        [Required]
        public ETrackingAppointmentChartType? type { get; set; }

        [Required]
        public string schema { get; set; }

        [Required]
        public string evolution { get; set; }

        [Required]
        public string conduct { get; set; }

        [Required]
        public DateOnly date { get; set; }

        [Required]
        public int? patientId { get; set; }
    }
}
