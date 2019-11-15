
namespace Serene1.CLIN.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("CLIN/AppFormulario"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.AppFormularioRow))]
    public class AppFormularioController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/CLIN/AppFormulario/AppFormularioIndex.cshtml");
        }
    }
}