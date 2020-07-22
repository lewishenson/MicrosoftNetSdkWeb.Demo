using Microsoft.Extensions.Configuration;

namespace MicrosoftNetSdkWeb.Demo.WorkingTest
{
    public class TestStartup : Startup
    {
        public TestStartup(IConfiguration configuration)
            : base(configuration)
        {
        }
    }
}