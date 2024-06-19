using CaitMazziniApp.Models.Base;

namespace CaitMazziniApp.Models.PatientClinicalHistory
{
    public class DatedImmunization : IId
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual IList<ClinicalHistory> ClinicalHistories { get; set; } = new List<ClinicalHistory>();
    }
}
