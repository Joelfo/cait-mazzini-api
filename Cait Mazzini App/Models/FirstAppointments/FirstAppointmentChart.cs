using CaitMazziniApp.Models.Base;
using CaitMazziniApp.Models.Core;

namespace CaitMazziniApp.Models.FirstAppointments
{
    public class FirstAppointmentChart : IId
    {
        public int Id { get; set; }

        public virtual Patient Patient { get; set; }

        public string MainIssues { get; set; }

        public string? DrugsInUse { get; set; } = "";

        public string? ComplementaryInfo { get; set; }

        public string Conduct { get; set; }

        public virtual User Creator { get; set; }
    }
}
