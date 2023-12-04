using CaitMazziniApp.Models.Base;

namespace CaitMazziniApp.Models.Exams
{
    public class ExamFile : BaseModel
    {
        public string? name { get; set; }

        public string FilePath { get; set; }

        public virtual ComplementaryExam ComplementaryExam { get; set; }
    }
}
