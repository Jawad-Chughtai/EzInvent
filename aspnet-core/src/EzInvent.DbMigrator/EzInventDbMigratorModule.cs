using EzInvent.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace EzInvent.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(EzInventEntityFrameworkCoreModule),
    typeof(EzInventApplicationContractsModule)
    )]
public class EzInventDbMigratorModule : AbpModule
{

}
