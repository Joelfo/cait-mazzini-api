using CaitMazziniApp.Models.Exams;

namespace CaitMazziniApp.Api.DTOs.Exams
{
    public class ComplementaryExamDTOWrapper<TExam>
        where TExam : ComplementaryExamDTO
    {
        public TExam examData { get; set; }

        public IFormFile file { get; set; }
    }
}
