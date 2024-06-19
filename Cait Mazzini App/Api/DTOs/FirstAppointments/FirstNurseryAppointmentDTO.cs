using System.ComponentModel.DataAnnotations;

namespace CaitMazziniApp.Api.DTOs.FirstAppointments
{
    public class FirstNurseryAppointmentDTO : FirstAppointmentDTO
    {
        [Required]
        public string NurseryDiagnostic { get; set; }
    }
}
