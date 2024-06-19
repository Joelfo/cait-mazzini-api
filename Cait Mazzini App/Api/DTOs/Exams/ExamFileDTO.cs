using System.ComponentModel.DataAnnotations;

namespace CaitMazziniApp.Api.DTOs.Exams
{
    public class ExamFileDTO 
    {
        public string? name { get; set; }

        [Required]
        public IFormFile file { get; set; } = null!;

        [Required]
        public int complementaryExamId;
    }
}
