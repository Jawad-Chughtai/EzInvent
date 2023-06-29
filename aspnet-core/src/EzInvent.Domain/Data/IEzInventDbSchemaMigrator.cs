using System.Threading.Tasks;

namespace EzInvent.Data;

public interface IEzInventDbSchemaMigrator
{
    Task MigrateAsync();
}
