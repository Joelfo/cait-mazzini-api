using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace CaitMazziniApp.Options.Setup
{
    public class JwtBearerOptionsSetup : IConfigureNamedOptions<JwtBearerOptions>
    {
        private readonly JwtOptions _jwtOptions;

        public JwtBearerOptionsSetup(IOptions<JwtOptions> jwtOptions)
        {
            _jwtOptions = jwtOptions.Value;
        }

        public void Configure(string? name, JwtBearerOptions options) 
        {
            Configure(options);
        }

        public void Configure(JwtBearerOptions options)
        {
            options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
            {
                ValidateIssuer = true,
                ValidateAudience = false,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = _jwtOptions.Issuer,
                ValidAudience = _jwtOptions.Audience,
                IssuerSigningKey = new SymmetricSecurityKey(Convert.FromBase64String(_jwtOptions.Key))
            };
        }
    }
}
