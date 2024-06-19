using CaitMazziniApp.Models.Base;
using CaitMazziniApp.Models.Core;

namespace CaitMazziniApp.Models.PatientClinicalHistory
{
    public class Immunization : IId
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public virtual IList<ClinicalHistory> ClinicalHistories { get; set; } = new List<ClinicalHistory>();
    }
}
