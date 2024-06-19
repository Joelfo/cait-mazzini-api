using CaitMazziniApp.Models.Base;

namespace CaitMazziniApp.Models.Core
{
    public class District : IId

    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public virtual City City { get; set; }

        public int CityId { get; set; }

        public virtual IList<Patient> Patients { get; set; } = new List<Patient>();
    }
}
