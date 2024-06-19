using System.ComponentModel.DataAnnotations;

namespace CaitMazziniApp.Api.DTOs.Exams
{
    public class OtherExamDTO : ComplementaryExamDTO
    {
        [Required]
        public string name { get; set; }
    }
}
