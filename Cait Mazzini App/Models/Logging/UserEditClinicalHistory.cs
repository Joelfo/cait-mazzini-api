using CaitMazziniApp.Models.PatientClinicalHistory;

namespace CaitMazziniApp.Models.Logging
{
    public class UserEditClinicalHistory : UserEditItem
    {
        public ClinicalHistory ClinicalHistory { get; set; }
    }
}
