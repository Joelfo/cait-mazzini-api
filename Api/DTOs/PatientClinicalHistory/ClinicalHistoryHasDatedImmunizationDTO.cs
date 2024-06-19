namespace CaitMazziniApp.Api.DTOs.PatientClinicalHistory
{
    public class ClinicalHistoryHasDatedImmunizationDTO
    {
        public int ImmunizationId { get; set; }

        public DateOnly LastDoseDate { get; set; }
    }
}
