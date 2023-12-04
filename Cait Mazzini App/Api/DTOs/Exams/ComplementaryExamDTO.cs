using System.ComponentModel.DataAnnotations;

namespace CaitMazziniApp.Api.DTOs.Exams
{
    public abstract class ComplementaryExamDTO
    {

        [Required]
        public DateOnly date { get; set; }

        [Required]
        public virtual int patientId { get; set; }

        [Required]
        public string observations { get; set; }
    }
}
