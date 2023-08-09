using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;

namespace $safeprojectname$.Controllers
{
    public class WebApiControllerBaseTests
    {
        [OneTimeSetUp]
        public void OneTimeSetup()
        {
        }

        protected internal HttpClient CreateClient(string authorizedUserName)
        {
            var webAppFactory = new CustomWebApplicationFactory<Program>();
            var factory = webAppFactory.WithWebHostBuilder(builder => {
                builder.ConfigureTestServices(services =>
                {
                    services.AddAuthentication(defaultScheme: "TestScheme")
                        .AddScheme<AuthenticationSchemeOptions, TestAuthHandler>("TestScheme", options => {
                            options.ClaimsIssuer = authorizedUserName;
                        });
                });
            });
            return factory.CreateClient();
        }
    }
}
