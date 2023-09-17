using System.ComponentModel.DataAnnotations;

namespace Cait_Mazzini_App.DTOs
{
    public class VitalSignsMeasurementDTO
    {
        [Required]
        public DateTime measurementDateTime { get; set; }

        [Required]
        public string mmhgPa { get; set; }

        [Required]
        public decimal bpmFc { get; set; }

        [Required]
        public decimal irpmFr { get; set; }

        [Required]
        public decimal celsiusTax { get; set; }

        [Required]
        public decimal oxygenSaturationPercentage { get; set; }

        [Required]
        public decimal kgWeight { get; set; }

        [Required]
        public decimal mHeight { get; set; }

        [Required]
        public int patientId { get; set; }
    }
}
