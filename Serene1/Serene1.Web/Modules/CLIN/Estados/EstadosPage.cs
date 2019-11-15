
namespace Serene1.CLIN.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("CLIN/Estados"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.EstadosRow))]
    public class EstadosController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/CLIN/Estados/EstadosIndex.cshtml");
        }
    }
}