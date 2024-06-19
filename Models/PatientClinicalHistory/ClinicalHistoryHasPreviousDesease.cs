namespace CaitMazziniApp.Models.PatientClinicalHistory
{
    public class ClinicalHistoryHasPreviousDesease
    {
        public virtual int DeseaseId { get; set; }

        public virtual int ClinicalHistoryId { get; set; }
    }
}
