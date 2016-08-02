using System.Web.Mvc;
using System.Web.SessionState;

namespace SalaoDoPantcho.Web.Controllers
{
    [SessionState(SessionStateBehavior.Disabled)]
    public class ProdutosController : Controller
    {
        #region Páginas

        // GET: Produtos
        public ActionResult Index()
        {
            return View();
        }

        #endregion
    }
}