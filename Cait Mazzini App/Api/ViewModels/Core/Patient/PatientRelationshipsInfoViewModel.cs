namespace CaitMazziniApp.Api.ViewModels.Core.Patient
{
    public class PatientRelationshipsInfoViewModel : PatientBasicInfoViewModel
    {
        public bool hasClinicalHistory { get; set; }

        public bool hasLifeHabitsInfo { get; set; }

        public bool hasScannedChart { get; set; }
    }
}
