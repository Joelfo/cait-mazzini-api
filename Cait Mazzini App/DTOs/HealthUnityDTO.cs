using System.ComponentModel.DataAnnotations;

namespace Cait_Mazzini_App.DTOs
{
    public class HealthUnityDTO
    {
        [Required]
        public string name { get; set; } = string.Empty;

        [Required]
        public int cityId { get; set; }
    } 
}
