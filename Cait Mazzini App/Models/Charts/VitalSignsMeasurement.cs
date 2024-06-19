using CaitMazziniApp.Models.Base;
using CaitMazziniApp.Models.Core;

namespace CaitMazziniApp.Models.Charts
{
    public class VitalSignsMeasurement : IId
    {
        public int Id { get; set; }

        public DateTime MeasurementDateTime { get; set; }

        public string MmhgPa { get; set; }

        public decimal BpmFc { get; set; }

        public decimal irpmFr { get; set; }

        public decimal CelsiusTax { get; set; }

        public decimal OxygenSaturationPercentage { get; set; }

        public decimal KgWeight { get; set; }

        public decimal MHeight { get; set; }

        public virtual Patient Patient { get; set; } = null!;

        public int? MgdlHgt { get; set; }
    }
}
