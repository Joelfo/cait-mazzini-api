using System.ComponentModel.DataAnnotations;

namespace CaitMazziniApp.DTOs
{
    public class FederativeUnityDTO
    {
        [Required]
        public string name { get; set; }

        [Required]
        public int? countryId { get; set; }
    }
}
