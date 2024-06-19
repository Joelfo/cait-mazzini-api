using CaitMazziniApp.Models.Base;

namespace CaitMazziniApp.Models.Exams
{
    public class ExamFileMetadata : IId
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string FilePath { get; set; }

        public virtual ComplementaryExam ComplementaryExam { get; set; }
    }
}
