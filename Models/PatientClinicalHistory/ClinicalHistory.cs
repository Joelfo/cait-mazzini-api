using CaitMazziniApp.Models.Base;
using CaitMazziniApp.Models.Core;

namespace CaitMazziniApp.Models.PatientClinicalHistory
{
    public class ClinicalHistory : IId
    {
        public int Id { get; set; }

        public virtual IList<Desease> PreviousDeseases { get; set; } = new List<Desease>();

        public string OtherPreviousDeseases { get; set; }

        public bool IsAlergic { get; set; }

        public string AlergyObs { get; set; } = string.Empty;

        public bool HasPreviousSurgery { get; set; }

        public string PreviousSurgeryObs { get; set; } = string.Empty;

        public bool HasPreviousHospitalizations { get; set; }

        public string PreviousHospitalizationsObs { get; set; } = string.Empty;

        public string TimeFromLastHospitalization { get; set; } = string.Empty;

        public virtual IList<Immunization> Immunizations { get; set; } = new List<Immunization>();

        public virtual IList<DatedImmunization> DatedImmunizations { get; set; } = new List<DatedImmunization>();

        public virtual IList<ClinicalHistoryHasDatedImmunization> ClinicalHistoryHasDatedImmunizations { get; set; } = new List<ClinicalHistoryHasDatedImmunization>();
        
        public string OtherImmunizations { get; set; } = string.Empty;

        public int PatientId { get; set; }

        public virtual Patient Patient { get; set; }
    }
}
