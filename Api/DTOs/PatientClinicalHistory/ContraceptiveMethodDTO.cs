using CaitMazziniApp.Controllers;
using System.ComponentModel.DataAnnotations;

namespace CaitMazziniApp.Api.DTOs.PatientClinicalHistory
{
    public class ContraceptiveMethodDTO
    {
        [Required]
        public string name { get; set; }
    }
}
