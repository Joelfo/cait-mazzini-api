using System.ComponentModel.DataAnnotations;

namespace Cait_Mazzini_App.DTOs
{
    public class CountryDTO
    {
        [Required] 
        public string name { get; set; }
    }
}
