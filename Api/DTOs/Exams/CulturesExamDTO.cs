using System.ComponentModel.DataAnnotations;

namespace CaitMazziniApp.Api.DTOs.Exams
{
    public class CulturesExamDTO : ComplementaryExamDTO
    {
        [Required]
        public Boolean isPositiveResult { get; set; }

        [Required]
        public string site { get; set; }
    }
}
