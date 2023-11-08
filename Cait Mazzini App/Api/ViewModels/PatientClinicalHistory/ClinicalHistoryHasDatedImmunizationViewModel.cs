using CaitMazziniApp.Models.PatientClinicalHistory;

namespace CaitMazziniApp.Api.ViewModels.PatientClinicalHistory
{
    public class ClinicalHistoryHasDatedImmunizationViewModel
    {
        public DatedImmunizationViewModel datedImmunization { get; set; }

        public DateOnly lastDoseDate { get; set; }
    }
}
