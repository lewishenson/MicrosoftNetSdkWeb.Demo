using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace MicrosoftNetSdkWeb.Demo.WorkingTest
{
    public class GivenThisProjectIncludesWebSdk : IClassFixture<TestWebApplicationFactory<TestStartup>>
    {
        private readonly HttpClient _client;

        public GivenThisProjectIncludesWebSdk(TestWebApplicationFactory<TestStartup> factory) =>
            _client = factory.CreateDefaultClient();

        [Fact]
        public async Task WhenMakingRequestToEndpointThatExists_ThenOkResponseReceived()
        {
            var response = await _client.GetAsync("weatherforecast");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
