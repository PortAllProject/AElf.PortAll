using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AElf.PortAll.Data;
using Volo.Abp.DependencyInjection;

namespace AElf.PortAll.EntityFrameworkCore
{
    public class EntityFrameworkCorePortAllDbSchemaMigrator
        : IPortAllDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCorePortAllDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the PortAllMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<PortAllMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}