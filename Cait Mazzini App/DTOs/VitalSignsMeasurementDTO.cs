namespace Cait_Mazzini_App.DTOs
{
    public class VitalSignsMeasurementDTO : BaseModelDTO
    {
        public DateTime measurementDateTime { get; set; }

        public double mmhgPa { get; set; }

        public double bpmFc { get; set; }

        public double celsiusTax { get; set; }

        public double oxygenSaturationPercentage { get; set; }

        public double kgWeight { get; set; }

        public double mHeight { get; set; }

        public long PatientId { get; set; }
    }
}
