using System.ComponentModel.DataAnnotations;

namespace CaitMazziniApp.Api.DTOs.Exams
{
    public class PCRExamDTO : ComplementaryExamDTO
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
