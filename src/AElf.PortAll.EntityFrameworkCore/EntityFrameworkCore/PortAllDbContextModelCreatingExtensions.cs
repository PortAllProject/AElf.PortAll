using AElf.PortAll.Queries;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace AElf.PortAll.EntityFrameworkCore
{
    public static class PortAllDbContextModelCreatingExtensions
    {
        public static void ConfigurePortAll(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            builder.Entity<Query>(b =>
            {
                b.ToTable($"{PortAllConsts.DbTablePrefix}Query", PortAllConsts.DbSchema);
                b.ConfigureByConvention();
                
                // Config Query properties.
                b.Property(q => q.QueryTransactionId).IsRequired().HasMaxLength(PortAllConsts.TransactionIdLength);
                b.Property(q => q.Payment).IsRequired();
                b.Property(q => q.AggregateThreshold).IsRequired();
                b.Property(q => q.CallbackContractAddress).IsRequired();
                b.Property(q => q.CallbackMethodName).IsRequired();
                b.Property(q => q.ExpirationTimestamp).IsRequired();
                b.Property(q => q.QueryId).IsRequired();
                b.Property(q => q.QueryTitle).IsRequired();
                b.Property(q => q.QuerySender).IsRequired();
                b.Property(q => q.DesignatedNodeList).IsRequired();
            });
        }
    }
}