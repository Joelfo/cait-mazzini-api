using CaitMazziniApp.Models.Base;
using CaitMazziniApp.Models.Core;

namespace CaitMazziniApp.Models.Charts
{
    public class PatientExam : BaseModel
    {
        public string FilePath { get; set; } = string.Empty;

        public DateOnly Date { get; set; }

        public virtual Patient Patient { get; set; }
    }
}
