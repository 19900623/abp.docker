using Microsoft.AspNetCore.Antiforgery;
using Bpo.Controllers;

namespace Bpo.Web.Host.Controllers
{
    public class AntiForgeryController : BpoControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
