using AutoMapper;
using CaitMazziniApp.Api.DTOs.Core;
using CaitMazziniApp.Models.Core;
using Isopoh.Cryptography.Argon2;
using System.Text;

namespace CaitMazziniApp.Mapper.Resolvers
{
    public class HashedPasswordResolver : IValueResolver<UserDTO, User, string>
    {
        public string Resolve(UserDTO userDTO, User user, string member, ResolutionContext context)
        {
            return Argon2.Hash(userDTO.password);
        }
    }
}
