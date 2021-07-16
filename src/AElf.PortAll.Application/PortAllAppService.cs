using System;
using System.Collections.Generic;
using System.Text;
using AElf.PortAll.Localization;
using Volo.Abp.Application.Services;

namespace AElf.PortAll
{
    /* Inherit your application services from this class.
     */
    public abstract class PortAllAppService : ApplicationService
    {
        protected PortAllAppService()
        {
            LocalizationResource = typeof(PortAllResource);
        }
    }
}
