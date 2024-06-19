using System.ComponentModel.DataAnnotations;

namespace CaitMazziniApp.Api.DTOs.Support
{
    public class PatientsAppointmentLineEntryDTO
    {
        [Required]
        public int patientId { get; set; }

        [Required]
        public int order { get; set; }
    }
}
