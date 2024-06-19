using CaitMazziniApp.Models.Base;
using CaitMazziniApp.Models.Core;

namespace CaitMazziniApp.Models.Charts
{
    public class PatientExam : IId
    {
        public int Id { get; set; }

        public string FilePath { get; set; } = string.Empty;

        public DateOnly Date { get; set; }

        public virtual Patient Patient { get; set; }
    }
}
