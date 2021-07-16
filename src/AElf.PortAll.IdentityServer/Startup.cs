using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace AElf.PortAll
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<PortAllIdentityServerModule>();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.InitializeApplication();
        }
    }
}
