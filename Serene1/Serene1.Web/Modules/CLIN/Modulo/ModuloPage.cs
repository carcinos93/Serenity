
namespace Serene1.CLIN.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("CLIN/Modulo"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.ModuloRow))]
    public class ModuloController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/CLIN/Modulo/ModuloIndex.cshtml");
        }
    }
}