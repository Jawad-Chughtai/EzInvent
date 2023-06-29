using EzInvent.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace EzInvent;

[DependsOn(
    typeof(EzInventEntityFrameworkCoreTestModule)
    )]
public class EzInventDomainTestModule : AbpModule
{

}
