using System.ComponentModel.DataAnnotations;

namespace CaitMazziniApp.DTOs
{
    public class HealthUnityDTO
    {
        [Required]
        public string name { get; set; } = string.Empty;
    } 
}
