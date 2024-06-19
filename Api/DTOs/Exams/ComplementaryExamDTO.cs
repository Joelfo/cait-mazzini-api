using System.ComponentModel.DataAnnotations;

namespace CaitMazziniApp.Api.DTOs.Exams
{
    public abstract class ComplementaryExamDTO
    {

        [Required]
        public string date { get; set; }

        [Required]
        public virtual int patientId { get; set; }

        public string? observations { get; set; }
    }
}
