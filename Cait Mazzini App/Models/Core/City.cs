using CaitMazziniApp.Models.Base;

namespace CaitMazziniApp.Models.Core
{
    public class City : IId
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;
    }
}
