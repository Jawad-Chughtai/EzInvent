using System;
using System.Collections.Generic;
using System.Text;
using EzInvent.Localization;
using Volo.Abp.Application.Services;

namespace EzInvent;

/* Inherit your application services from this class.
 */
public abstract class EzInventAppService : ApplicationService
{
    protected EzInventAppService()
    {
        LocalizationResource = typeof(EzInventResource);
    }
}
