using Cait_Mazzini_App.Models.Base;

namespace Cait_Mazzini_App.Models
{
    public class District : BaseModel
    {
        public string Name { get; set; } = string.Empty;

        public virtual City City { get; set; }
    }
}
