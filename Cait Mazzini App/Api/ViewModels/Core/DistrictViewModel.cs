using System.ComponentModel.DataAnnotations;

namespace CaitMazziniApp.ViewModels
{
    public class DistrictViewModel
    {
        public int id { get; set; }

        public string name { get; set; } = string.Empty;

        public int cityId { get; set; }
    }
}
