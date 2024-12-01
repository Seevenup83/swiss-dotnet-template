using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;
using FluentAssertions;

namespace TemplateTests
{
    public class HealthCheckTests : IClassFixture<WebApplicationFactory<Blazor_Server_Template.Program>>
    {
        private readonly WebApplicationFactory<Blazor_Server_Template.Program> _factory;

        public HealthCheckTests(WebApplicationFactory<Blazor_Server_Template.Program> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task HealthEndpoint_ShouldReturnHealthy()
        {
            var client = _factory.CreateClient();
            var response = await client.GetAsync("/health");
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            var content = await response.Content.ReadAsStringAsync();
            content.Should().Contain("Healthy");
        }
    }
}
