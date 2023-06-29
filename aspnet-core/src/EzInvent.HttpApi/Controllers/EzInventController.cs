using EzInvent.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace EzInvent.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class EzInventController : AbpControllerBase
{
    protected EzInventController()
    {
        LocalizationResource = typeof(EzInventResource);
    }
}
