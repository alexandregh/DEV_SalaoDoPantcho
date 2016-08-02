using System.Web.Mvc;
using System.Web.SessionState;

namespace SalaoDoPantcho.Web.Controllers
{
    [OutputCache(Duration = 43200)]
    [SessionState(SessionStateBehavior.Disabled)]
    public class GaleriasController : Controller
    {
        #region Páginas

        // GET: Galerias
        public ActionResult Index()
        {
            return View();
        }

        #endregion
    }
}