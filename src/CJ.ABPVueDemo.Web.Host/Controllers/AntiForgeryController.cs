using Microsoft.AspNetCore.Antiforgery;
using CJ.ABPVueDemo.Controllers;

namespace CJ.ABPVueDemo.Web.Host.Controllers
{
    public class AntiForgeryController : ABPVueDemoControllerBase
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
