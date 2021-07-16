using AElf.PortAll.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AElf.PortAll.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class PortAllController : AbpController
    {
        protected PortAllController()
        {
            LocalizationResource = typeof(PortAllResource);
        }
    }
}