
namespace Serene1.CLIN.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("CLIN/PlantillaCorreo"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.PlantillaCorreoRow))]
    public class PlantillaCorreoController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/CLIN/PlantillaCorreo/PlantillaCorreoIndex.cshtml");
        }
    }
}