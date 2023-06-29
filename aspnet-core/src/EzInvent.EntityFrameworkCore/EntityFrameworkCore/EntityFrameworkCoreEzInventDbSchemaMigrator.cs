using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using EzInvent.Data;
using Volo.Abp.DependencyInjection;

namespace EzInvent.EntityFrameworkCore;

public class EntityFrameworkCoreEzInventDbSchemaMigrator
    : IEzInventDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreEzInventDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the EzInventDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<EzInventDbContext>()
            .Database
            .MigrateAsync();
    }
}
