using System.Web.Mvc;
using System.Web.SessionState;

namespace SalaoDoPantcho.Web.Controllers
{
    [OutputCache(Duration = 43200)]
    [SessionState(SessionStateBehavior.Disabled)]
    public class SistemaController : Controller
    {
        #region Páginas

        // GET: Sistema
        public ActionResult Index()
        {
            return View();
        }

        #endregion
    }
}