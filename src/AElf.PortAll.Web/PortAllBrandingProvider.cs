using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace AElf.PortAll.Web
{
    [Dependency(ReplaceServices = true)]
    public class PortAllBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "PortAll";
    }
}
