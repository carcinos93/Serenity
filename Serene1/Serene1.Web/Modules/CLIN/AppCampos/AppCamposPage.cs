
namespace Serene1.CLIN.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("CLIN/AppCampos"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.AppCamposRow))]
    public class AppCamposController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/CLIN/AppCampos/AppCamposIndex.cshtml");
        }
    }
}