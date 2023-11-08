namespace CaitMazziniApp.Models.PatientClinicalHistory
{
    public class ClinicalHistoryHasImmunization
    {

        public virtual int ClinicalHistoryId { get; set; }


        public virtual int ImmunizationId { get; set; }
    }
}
