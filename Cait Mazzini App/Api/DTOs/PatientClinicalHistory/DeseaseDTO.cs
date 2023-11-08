using System.ComponentModel.DataAnnotations;

namespace CaitMazziniApp.Api.DTOs.PatientClinicalHistory
{
    public class DeseaseDTO
    {
        [Required]
        public string name { get; set; }


    }
}
