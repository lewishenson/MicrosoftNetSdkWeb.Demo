using Microsoft.Extensions.Configuration;

namespace MicrosoftNetSdkWeb.Demo.BrokenTest
{
    public class TestStartup : Startup
    {
        public TestStartup(IConfiguration configuration)
            : base(configuration)
        {
        }
    }
}