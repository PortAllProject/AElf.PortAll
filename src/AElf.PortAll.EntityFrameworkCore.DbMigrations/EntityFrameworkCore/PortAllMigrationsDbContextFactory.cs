using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace AElf.PortAll.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class PortAllMigrationsDbContextFactory : IDesignTimeDbContextFactory<PortAllMigrationsDbContext>
    {
        public PortAllMigrationsDbContext CreateDbContext(string[] args)
        {
            PortAllEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<PortAllMigrationsDbContext>()
                .UseMySql(configuration.GetConnectionString("Default"), ServerVersion.FromString("8.0.25-mysql"));

            return new PortAllMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../AElf.PortAll.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
