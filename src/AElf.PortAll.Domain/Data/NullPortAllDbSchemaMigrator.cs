using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AElf.PortAll.Data
{
    /* This is used if database provider does't define
     * IPortAllDbSchemaMigrator implementation.
     */
    public class NullPortAllDbSchemaMigrator : IPortAllDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}