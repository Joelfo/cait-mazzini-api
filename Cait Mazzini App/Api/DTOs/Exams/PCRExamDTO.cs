using System.ComponentModel.DataAnnotations;

namespace CaitMazziniApp.Api.DTOs.Exams
{
    public class PCRExamDTO : ComplementaryExamDTO
    {
        [Required]
        public Boolean isPositiveResult { get; set; }
    }
}
