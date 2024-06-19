using System.ComponentModel.DataAnnotations;

namespace CaitMazziniApp.Api.DTOs.PatientClinicalHistory
{
    public class DatedImmunizationDTO
    {
        [Required]
        public string name { get; set; }
    }
}
