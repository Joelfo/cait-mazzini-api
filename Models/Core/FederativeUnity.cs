using CaitMazziniApp.Models.Base;

namespace CaitMazziniApp.Models.Core
{
    public class FederativeUnity : IId
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public virtual Country Country { get; set; }

        public int CountryId { get; set; }
    }
}
