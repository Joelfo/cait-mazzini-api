namespace CaitMazziniApp.Models.PatientClinicalHistory
{
    public class ClinicalHistoryHasDatedImmunization
    {
        public int DatedImmunizationId { get; set; }

        public int ClinicalHistoryId { get; set; }

        public DateOnly LastDoseDate { get; set; }

        public virtual ClinicalHistory ClinicalHistory { get; set; }

        public virtual DatedImmunization DatedImmunization { get; set;}
    }
}
