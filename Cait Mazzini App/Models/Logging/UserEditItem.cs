using CaitMazziniApp.Models.Base;
using CaitMazziniApp.Models.Core;

namespace CaitMazziniApp.Models.Logging
{
    public class UserEditItem
    {
        public DateTime DateTime { get; set; }

        public User user { get; set; }
    }
}
