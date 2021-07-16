using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace AElf.PortAll.EntityFrameworkCore
{
    public static class PortAllDbContextModelCreatingExtensions
    {
        public static void ConfigurePortAll(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(PortAllConsts.DbTablePrefix + "YourEntities", PortAllConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}