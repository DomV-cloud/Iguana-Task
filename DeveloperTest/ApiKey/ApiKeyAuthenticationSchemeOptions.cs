using Microsoft.AspNetCore.Authentication;

namespace DeveloperTest.ApiKey
{
    public class ApiKeyAuthenticationSchemeOptions : AuthenticationSchemeOptions
    {
        public string? ApiKey { get; set; }
    }
}
