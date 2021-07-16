using AElf.PortAll.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace AElf.PortAll.Web.Pages
{
    public abstract class PortAllPageModel : AbpPageModel
    {
        protected PortAllPageModel()
        {
            LocalizationResourceType = typeof(PortAllResource);
        }
    }
}