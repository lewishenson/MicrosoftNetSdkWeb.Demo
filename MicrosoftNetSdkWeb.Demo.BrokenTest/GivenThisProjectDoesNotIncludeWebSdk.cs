using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace MicrosoftNetSdkWeb.Demo.BrokenTest
{
    public class GivenThisProjectDoesNotIncludeWebSdk : IClassFixture<TestWebApplicationFactory<TestStartup>>
    {
        private readonly HttpClient _client;

        public GivenThisProjectDoesNotIncludeWebSdk(TestWebApplicationFactory<TestStartup> factory) =>
            _client = factory.CreateDefaultClient();

        [Fact]
        public async Task WhenMakingRequestToEndpointThatExists_ThenOkResponseReceived()
        {
            var response = await _client.GetAsync("weatherforecast");

            // This will fail as a 404 Not Found response has been returned
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
