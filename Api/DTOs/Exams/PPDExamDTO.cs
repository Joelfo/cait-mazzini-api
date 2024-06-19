using CaitMazziniApp.Models.Core;
using System.ComponentModel.DataAnnotations;

namespace CaitMazziniApp.Api.DTOs.Exams
{
    public class PPDExamDTO : ComplementaryExamDTO
    {
        [Required]
        public Boolean isReactiveResult { get; set; }
    }
}
