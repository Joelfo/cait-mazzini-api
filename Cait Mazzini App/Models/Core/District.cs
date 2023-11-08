using CaitMazziniApp.Models.Base;

namespace CaitMazziniApp.Models.Core
{
    public class District : BaseModel
    {
        public string Name { get; set; } = string.Empty;

        public virtual City City { get; set; }

        public int CityId { get; set; }
    }
}
