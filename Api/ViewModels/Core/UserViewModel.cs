using CaitMazziniApp.Enums;

namespace CaitMazziniApp.ViewModels
{
    public class UserViewModel
    {
        public int id { get; set; } 

        public string cpf { get; set; }

        public string email { get; set; }

        public string name { get; set; }

        public EUserRole role { get; set; }
    }
}
