using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace CaitMazziniApp.DTOs.NurseryIdentificationInfo
{
    public class NurseryIdentificationInfoDTO
    {
        [Required]
        public string mainIssues { get; set; }

        [Required]
        public string drugsInUse { get; set; }

        public string complementaryInfo { get; set; } = String.Empty;

        [Required]
        public string nurseryConduct { get; set; }

        [Required]
        public int patientId { get; set; }
    }
}
