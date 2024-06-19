using CaitMazziniApp.Enums;

namespace CaitMazziniApp.Api.ViewModels.PatientClinicalHistory
{
    public class PhysicalExamViewModel
    {
        public int id { get; set; }

        public string generalAspect { get; set; } = String.Empty;

        public string hygieneConditionsObs { get; set; } = String.Empty;

        public string headObs { get; set; } = String.Empty;

        public string neckObs { get; set; } = String.Empty;

        public string chestObs { get; set; } = String.Empty;

        public string abdomenObs { get; set; } = String.Empty;

        public string mmssMmiiObs { get; set; } = String.Empty;

        public string urinaryTrackObs { get; set; } = String.Empty;

        public string skinAndMucousObs { get; set; } = String.Empty;

        public int patientId { get; set; }

        public ETrackingAppointmentChartType type { get; set; }

        public DateOnly date { get; set; }
    }
}
