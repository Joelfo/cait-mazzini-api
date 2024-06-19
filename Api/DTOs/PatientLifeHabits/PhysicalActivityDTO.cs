using System.ComponentModel.DataAnnotations;

namespace CaitMazziniApp.Api.DTOs.PatientLifeHabits
{
    public class PhysicalActivityDTO
    {
        [Required]
        public string name { get; set; }
    }
}
