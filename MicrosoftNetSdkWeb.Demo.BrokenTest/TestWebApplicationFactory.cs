using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Hosting;

namespace MicrosoftNetSdkWeb.Demo.BrokenTest
{
    public class TestWebApplicationFactory<T> : WebApplicationFactory<Startup> where T : Startup
    {
        protected override IHostBuilder CreateHostBuilder()
        {
            return base.CreateHostBuilder()
                .ConfigureWebHost(configure => configure.UseStartup<T>());
        }
    }
}