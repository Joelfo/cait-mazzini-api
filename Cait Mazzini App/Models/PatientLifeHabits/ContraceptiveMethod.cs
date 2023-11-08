using CaitMazziniApp.Models.Base;

namespace CaitMazziniApp.Models.PatientLifeHabits
{
    public class ContraceptiveMethod : BaseModel
    {
        public string Name { get; set; }

        public virtual IList<LifeHabitsInfo> LifeHabitsInfos { get; set; } = new List<LifeHabitsInfo>();
    }
}
