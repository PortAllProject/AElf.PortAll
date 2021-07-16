using System.Threading.Tasks;

namespace AElf.PortAll.Data
{
    public interface IPortAllDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
