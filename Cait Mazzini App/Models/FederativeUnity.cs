using Cait_Mazzini_App.Models.Base;

namespace Cait_Mazzini_App.Models
{
    public class FederativeUnity : BaseModel
    {
        public string Name { get; set; } = string.Empty;

        public virtual Country Country { get; set; }
    }
}
