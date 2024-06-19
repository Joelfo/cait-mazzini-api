using CaitMazziniApp.Enums;
using System.ComponentModel.DataAnnotations;

namespace CaitMazziniApp.Api.DTOs.Exams
{
    public class ToraxXRayExamDTO : ComplementaryExamDTO
    {
        [Required]
        public EToraxXRayResult xRayResult { get; set; }
    }
}
