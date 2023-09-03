using Cait_Mazzini_App.Models.Base;

namespace Cait_Mazzini_App.Models
{
    public class VitalSignsMeasurement : BaseModel
    {
        public DateTime MeasurementDateTime { get; set; }

        public double MmhgPa { get; set; }

        public double BpmFc { get; set; }

        public double CelsiusTax { get; set; }

        public double OxygenSaturationPercentage { get; set; }

        public double KgWeight { get; set; }

        public double MHeight { get; set; }

        public virtual Patient Patient { get; set; }
    }
}
