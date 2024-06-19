using CaitMazziniApp.Models.Core;

namespace CaitMazziniApp.Models.Support
{
    public class PatientsAppointmentLineEntry
    {
        public int PatientId { get; set; }
        
        public virtual Patient Patient { get; set; }

        public int Order { get; set; }


    }
}
