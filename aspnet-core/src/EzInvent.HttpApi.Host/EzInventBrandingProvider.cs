using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace EzInvent;

[Dependency(ReplaceServices = true)]
public class EzInventBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "EzInvent";
}
