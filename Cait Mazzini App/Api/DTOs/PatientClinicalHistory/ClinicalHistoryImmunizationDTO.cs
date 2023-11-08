using System.ComponentModel.DataAnnotations;

namespace CaitMazziniApp.Api.DTOs.PatientClinicalHistory
{
    public class ClinicalHistoryImmunizationDTO
    {
        [Required]
        public int id { get; set; }

        [Required]
        public string timeFromLastDose { get; set; }
    }
}
