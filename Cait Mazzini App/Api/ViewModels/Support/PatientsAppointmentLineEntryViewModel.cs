using CaitMazziniApp.Api.ViewModels.Core.Patient;

namespace CaitMazziniApp.Api.ViewModels.Support
{
    public class PatientsAppointmentLineEntryViewModel
    {
        public PatientBasicInfoViewModel Patient { get; set; }

        public int order { get; set; }
    }
}
