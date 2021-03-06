using AElf.PortAll.Queries;
using Microsoft.EntityFrameworkCore;
using AElf.PortAll.Users;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.Identity;
using Volo.Abp.Users.EntityFrameworkCore;

namespace AElf.PortAll.EntityFrameworkCore
{
    /* This is your actual DbContext used on runtime.
     * It includes only your entities.
     * It does not include entities of the used modules, because each module has already
     * its own DbContext class. If you want to share some database tables with the used modules,
     * just create a structure like done for AppUser.
     *
     * Don't use this DbContext for database migrations since it does not contain tables of the
     * used modules (as explained above). See PortAllMigrationsDbContext for migrations.
     */
    [ConnectionStringName("Default")]
    public class PortAllDbContext : AbpDbContext<PortAllDbContext>
    {
        public DbSet<AppUser> Users { get; set; }

        public DbSet<Query> Queries { get; set; }

        /* Add DbSet properties for your Aggregate Roots / Entities here.
         * Also map them inside PortAllDbContextModelCreatingExtensions.ConfigurePortAll
         */

        public PortAllDbContext(DbContextOptions<PortAllDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /* Configure the shared tables (with included modules) here */

            builder.Entity<AppUser>(b =>
            {
                b.ToTable($"{AbpIdentityDbProperties.DbTablePrefix}Users");
                b.ConfigureByConvention();
                b.ConfigureAbpUser();
                /* Configure mappings for your additional properties
                 * Also see the PortAllEfCoreEntityExtensionMappings class
                 */
            });

            /* Configure your own tables/entities inside the ConfigurePortAll method */

            builder.ConfigurePortAll();
        }
    }
}
