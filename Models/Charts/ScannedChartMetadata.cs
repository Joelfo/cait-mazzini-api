using CaitMazziniApp.Models.Base;
using CaitMazziniApp.Models.Core;

namespace CaitMazziniApp.Models.Charts
{
    public class ScannedChartMetadata : IId
    {
        public int Id { get; set; }

        public virtual Patient Patient { get; set; }

        public string FilePath { get; set; }
    }
}
