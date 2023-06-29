using Volo.Abp.Modularity;

namespace EzInvent;

[DependsOn(
    typeof(EzInventApplicationModule),
    typeof(EzInventDomainTestModule)
    )]
public class EzInventApplicationTestModule : AbpModule
{

}
