using System.ComponentModel.DataAnnotations;

namespace Cait_Mazzini_App.ViewModels
{
    public class DistrictViewModel
    {
        [Required]
        public string name { get; set; } = string.Empty;

        [Required]
        public int cityId { get; set; }
    }
}
