using System.Web.Mvc;
using System.Web.SessionState;

namespace SalaoDoPantcho.Web.Controllers
{
    [OutputCache(Duration = 43200)]
    [SessionState(SessionStateBehavior.Disabled)]
    public class SobreController : Controller
    {
        #region Páginas

        // GET: Sobre
        public ActionResult Index()
        {
            return View();
        }

        #endregion
    }
}