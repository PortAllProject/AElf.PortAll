using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace AElf.PortAll.EntityFrameworkCore
{
    [DependsOn(
        typeof(PortAllEntityFrameworkCoreModule)
        )]
    public class PortAllEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<PortAllMigrationsDbContext>();
        }
    }
}
