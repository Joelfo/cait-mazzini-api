using CaitMazziniApp.Enums;
using CaitMazziniApp.Models.Base;

namespace CaitMazziniApp.Models.Core
{
    public class User : IId
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public EUserRole Role { get; set; }

        public string Cpf { get; set; }

        public string HashedPassowrd { get; set; }

        public string Email { get; set; }
    }
}
