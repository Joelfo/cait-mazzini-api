using System.ComponentModel.DataAnnotations;

namespace CaitMazziniApp.DTOs
{
    public class DistrictDTO
    {

        [Required]
        public string name { get; set; } = string.Empty;

        [Required]
        public int cityId { get; set; }
    }
}
