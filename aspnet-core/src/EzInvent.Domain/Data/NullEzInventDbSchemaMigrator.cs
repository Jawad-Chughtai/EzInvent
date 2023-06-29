using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace EzInvent.Data;

/* This is used if database provider does't define
 * IEzInventDbSchemaMigrator implementation.
 */
public class NullEzInventDbSchemaMigrator : IEzInventDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
