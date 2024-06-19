using System.ComponentModel.DataAnnotations;

namespace CaitMazziniApp.Api.DTOs.Exams
{
    public class IgraExamDTO : ComplementaryExamDTO
    {
        [Required]
        public Boolean isPositiveResult { get; set; }

        [Required]
        public string material { get; set; }

        [Required]
        public string kit { get; set; }

        [Required]
        public string method { get; set; }
    }
}
