using System.Web.Mvc;
using System.Web.SessionState;

namespace SalaoDoPantcho.Web.Controllers
{
    [OutputCache(Duration = 43200)]
    [SessionState(SessionStateBehavior.Disabled)]
    public class LocalizacaoController : Controller
    {
        #region Páginas

        // GET: Localizacao
        public ActionResult Index()
        {
            return View();
        }

        #endregion
    }
}