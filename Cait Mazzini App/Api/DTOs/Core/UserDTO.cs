using CaitMazziniApp.Enums;

namespace CaitMazziniApp.Api.DTOs.Core
{
    public class UserDTO
    {
        public string name { get; set; }

        public string cpf { get; set; }

        public string email { get; set; }

        public string password { get; set; }

        public EUserRole role { get; set; }
    }
}
