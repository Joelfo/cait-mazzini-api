using System.ComponentModel.DataAnnotations;

namespace CaitMazziniApp.Api.ViewModels.PatientClinicalHistory
{
    public class ClinicalHistoryImmunizationViewModel
    {
        public int id { get; set; }

        public string timeFromLastDose { get; set; }

    }
}
