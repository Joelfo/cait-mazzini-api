using AutoMapper;
using CaitMazziniApp.Api.DTOs.Auth;
using CaitMazziniApp.Database.Repositories.Interfaces;
using CaitMazziniApp.Models.Core;
using CaitMazziniApp.Options;
using CaitMazziniApp.ViewModels;
using Isopoh.Cryptography.Argon2;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace CaitMazziniApp.Api.Controllers.Auth
{
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly JwtOptions _jwtConfiguration;
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public AuthController(IOptions<JwtOptions> jwtConfiguration, IUserRepository userRepository, IMapper mapper)
        {
            _jwtConfiguration = jwtConfiguration.Value;
            _userRepository = userRepository;
            _mapper = mapper;
        }
        
        [HttpPost]
        [AllowAnonymous]
        [EnableCors]
        public async Task<IActionResult> Login([FromBody] LoginDTO loginDTO)
        {
            var user = await _userRepository.GetByCpf(loginDTO.cpf);

            if (user == null)
            {
                return BadRequest();
            }
            else if (Argon2.Verify(user.HashedPassowrd, loginDTO.password))
            {
                var claims = new List<Claim>
                {
                    new Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
                    new Claim(ClaimTypes.Role, user.Role.ToString()),
                };

                var securityKey = new SymmetricSecurityKey(Convert.FromBase64String(_jwtConfiguration.Key));
                var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(
                    audience: _jwtConfiguration.Audience,
                    issuer: _jwtConfiguration.Issuer,
                    claims: claims,
                    expires: DateTime.UtcNow.AddHours(8),
                    signingCredentials: credentials
                );

                string tokenValue = new JwtSecurityTokenHandler().WriteToken(token);
                return Ok(tokenValue);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet("CheckToken")]
        public async Task<IActionResult> CheckToken()
        {
            return Ok();
        }

        [HttpGet("User"), Authorize]
        public async Task<IActionResult> GetUser()
        {
            var identity = HttpContext.User.Identity;
            if (identity != null)
            {
                string subClaim = User.FindFirstValue(ClaimTypes.NameIdentifier);
                bool canParse = int.TryParse(subClaim, out int id);
                if (canParse)
                {
                    var user = await _userRepository.Find(id);
                    var viewModel = _mapper.Map<UserViewModel>(user);
                    return Ok(viewModel);
                }
            }
            return Unauthorized();
        }
    }
}
