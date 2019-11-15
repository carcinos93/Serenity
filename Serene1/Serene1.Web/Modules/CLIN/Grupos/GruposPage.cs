
namespace Serene1.CLIN.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("CLIN/Grupos"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.GruposRow))]
    public class GruposController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/CLIN/Grupos/GruposIndex.cshtml");
        }
    }
}