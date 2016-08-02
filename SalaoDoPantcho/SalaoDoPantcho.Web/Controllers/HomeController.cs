using System.Web.Mvc;
using System.Web.SessionState;

namespace SalaoDoPantcho.Web.Controllers
{
    [OutputCache(Duration = 43200)]
    [SessionState(SessionStateBehavior.Disabled)]
    public class HomeController : Controller
    {
        #region Páginas

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        #endregion
    }
}