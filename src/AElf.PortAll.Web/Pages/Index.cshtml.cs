using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace AElf.PortAll.Web.Pages
{
    public class IndexModel : PortAllPageModel
    {
        public void OnGet()
        {
            
        }

        public async Task OnPostLoginAsync()
        {
            await HttpContext.ChallengeAsync("oidc");
        }
    }
}