using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Options;

namespace CaitMazziniApp.Options.Setup
{
    public class AuthorizationOptionsSetup : IConfigureOptions<AuthorizationOptions>
    {
        public void Configure(AuthorizationOptions options)
        {
            options.FallbackPolicy = new AuthorizationPolicyBuilder()
                .RequireAuthenticatedUser()
                .Build();
        }
    }
}
