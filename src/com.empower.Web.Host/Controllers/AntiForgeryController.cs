using Microsoft.AspNetCore.Antiforgery;
using com.empower.Controllers;

namespace com.empower.Web.Host.Controllers
{
    public class AntiForgeryController : empowerControllerBase
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
