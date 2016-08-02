using System.Web.Mvc;
using System.Web.SessionState;

namespace SalaoDoPantcho.Web.Controllers
{
    [SessionState(SessionStateBehavior.Disabled)]
    public class ServicosController : Controller
    {
        #region Páginas

        // GET: Servicos
        public ActionResult Index()
        {
            return View();
        }

        #endregion
    }
}