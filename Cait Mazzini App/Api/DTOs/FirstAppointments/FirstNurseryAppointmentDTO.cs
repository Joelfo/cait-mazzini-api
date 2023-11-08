using System.ComponentModel.DataAnnotations;

namespace CaitMazziniApp.Api.DTOs.FirstAppointments
{
    public class FirstNurseryAppointmentDTO : FirstAppointmentDTO
    {
        [Required]
        public string NurseryDiagnosis { get; set; }

        [Required]
        public string NurseryConduct { get; set; }
    }
}
