using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using System.Text;

namespace CaitMazziniApp.Api.Controllers
{
    [Route("Util")]
    public class UtilController : ControllerBase
    {
        [HttpGet("/GetNBytesKey")]
        [AllowAnonymous]
        public IActionResult GetNBytesKey([FromQuery] int numBytes)
        {
            var key = RandomNumberGenerator.GetBytes(numBytes);
            return Ok(Convert.ToBase64String(key));
        }
    }
}
