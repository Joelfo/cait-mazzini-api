using CaitMazziniApp.Enums;
using System.ComponentModel.DataAnnotations;

namespace CaitMazziniApp.DTOs
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
