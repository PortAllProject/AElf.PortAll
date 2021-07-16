using AElf.PortAll.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AElf.PortAll
{
    [DependsOn(
        typeof(PortAllEntityFrameworkCoreTestModule)
        )]
    public class PortAllDomainTestModule : AbpModule
    {

    }
}