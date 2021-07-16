using Volo.Abp.Modularity;

namespace AElf.PortAll
{
    [DependsOn(
        typeof(PortAllApplicationModule),
        typeof(PortAllDomainTestModule)
        )]
    public class PortAllApplicationTestModule : AbpModule
    {

    }
}