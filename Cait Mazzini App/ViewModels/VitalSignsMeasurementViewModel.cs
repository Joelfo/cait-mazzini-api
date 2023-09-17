using System.ComponentModel.DataAnnotations;

namespace Cait_Mazzini_App.ViewModels
{
    public class VitalSignsMeasurementViewModel
    {
        public DateTime measurementDateTime { get; set; }

        public string mmhgPa { get; set; }

        public decimal bpmFc { get; set; }

        public decimal irpmFr { get; set; }

        public decimal celsiusTax { get; set; }

        public decimal oxygenSaturationPercentage { get; set; }

        public decimal kgWeight { get; set; }

        public decimal mHeight { get; set; }

        public int patientId { get; set; }
    }
}
