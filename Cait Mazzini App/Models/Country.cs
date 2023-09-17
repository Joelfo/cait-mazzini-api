using Cait_Mazzini_App.Models.Base;

namespace Cait_Mazzini_App.Models
{
    public class Country : BaseModel
    {
        public string Name { get; set; } = string.Empty;

        public virtual ICollection<Patient> Patients { get; set; } = new List<Patient>();
    }
}
