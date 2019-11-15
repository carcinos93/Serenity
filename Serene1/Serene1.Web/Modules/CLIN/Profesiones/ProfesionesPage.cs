
namespace Serene1.CLIN.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("CLIN/Profesiones"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.ProfesionesRow))]
    public class ProfesionesController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/CLIN/Profesiones/ProfesionesIndex.cshtml");
        }
    }
}