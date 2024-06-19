using System.ComponentModel.DataAnnotations;

namespace CaitMazziniApp.DTOs
{
    public class CountryDTO
    {
        [Required] 
        public string name { get; set; }
    }
}
