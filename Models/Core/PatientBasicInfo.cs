using CaitMazziniApp.Models.Base;

namespace CaitMazziniApp.Models.Core
{
    public class PatientBasicInfo : IId
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string RecordCode { get; set; }
    }
}
