using CaitMazziniApp.Models.Base;
using CaitMazziniApp.Models.Core;

namespace CaitMazziniApp.Models.FirstAppointments
{
    public class FirstAppointment : BaseModel
    {
        public virtual Patient Patient { get; set; }

        public int PatientId { get; set; }

        public string MainIssues { get; set; }

        public string DrugsInUse { get; set; }

        public string? ComplementaryInfo { get; set; }
    }
}
