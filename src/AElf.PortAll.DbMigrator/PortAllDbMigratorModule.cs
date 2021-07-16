using AElf.PortAll.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace AElf.PortAll.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(PortAllEntityFrameworkCoreDbMigrationsModule),
        typeof(PortAllApplicationContractsModule)
        )]
    public class PortAllDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
