using System.ComponentModel.DataAnnotations;

namespace CaitMazziniApp.Api.DTOs.Exams
{
    public class BiopsyExamDTO : ComplementaryExamDTO
    {
        [Required]
        public string analyzedTissue { get; set; }

        [Required]
        public string result { get; set; }
    }
}
