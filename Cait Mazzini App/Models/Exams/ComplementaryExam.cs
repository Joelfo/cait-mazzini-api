using CaitMazziniApp.Enums;
using CaitMazziniApp.Models.Base;
using CaitMazziniApp.Models.Core;

namespace CaitMazziniApp.Models.Exams
{
    public class ComplementaryExam : BaseModel
    {
        public string FilePath { get; set; } = string.Empty;

        public DateOnly Date { get; set; }

        public virtual Patient Patient { get; set; }

        public string Observations { get; set; }
    }
}
