using CaitMazziniApp.Enums;
using System.ComponentModel.DataAnnotations;

namespace CaitMazziniApp.Api.DTOs.Exams
{
    public class BaarExamDTO : ComplementaryExamDTO
    {
        [Required]
        public int monthNumber { get; set; }

        [Required]
        public int sampleNumber { get; set; }

        [Required]
        public Boolean isMaterialSputum { get; set; }

        public string? otherMaterial { get; set; }

        [Required]
        public ESputumAspect sputumAspect { get; set; }

        [Required]
        public EBaarResult result { get; set; }
    }
}
