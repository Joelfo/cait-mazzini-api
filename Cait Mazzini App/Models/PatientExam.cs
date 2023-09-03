using Cait_Mazzini_App.Models.Base;

namespace Cait_Mazzini_App.Models
{
    public class PatientExam : BaseModel
    {
        public string FilePath { get; set; } = string.Empty;

        public DateOnly Date { get; set; }

        public virtual Patient Patient { get; set; }
    }
}
