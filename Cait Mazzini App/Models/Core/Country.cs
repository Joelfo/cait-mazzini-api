using CaitMazziniApp.Models.Base;

namespace CaitMazziniApp.Models.Core
{
    public class Country : BaseModel
    {
        public string Name { get; set; } = string.Empty;

        public virtual ICollection<Patient> Patients { get; set; } = new List<Patient>();
    }
}
