using System.ComponentModel.DataAnnotations;

namespace Cait_Mazzini_App.DTOs
{
    public class FederativeUnityDTO
    {
        [Required]
        public string name { get; set; }

        [Required]
        public int? countryId { get; set; }
    }
}
