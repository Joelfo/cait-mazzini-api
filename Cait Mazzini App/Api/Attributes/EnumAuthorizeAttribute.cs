using CaitMazziniApp.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.VisualBasic;
using System.Data;

namespace CaitMazziniApp.Api.Annotations
{
    public class EnumAuthorizeAttribute : AuthorizeAttribute
    {
        public EnumAuthorizeAttribute(EUserRole roleEnum)
        {
            Roles = roleEnum.ToString().Replace(" ", string.Empty);
        }
    }
}
