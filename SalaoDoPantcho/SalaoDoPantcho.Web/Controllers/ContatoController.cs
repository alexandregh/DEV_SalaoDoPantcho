using System;
using System.Web.Mvc;
using SalaoDoPantcho.Entity.Utilitarios.Contatos;
using SalaoDoPantcho.Web.Models.Utilitarios.Contato;
using System.Web.SessionState;

namespace SalaoDoPantcho.Web.Controllers
{
    [SessionState(SessionStateBehavior.Disabled)]
    public class ContatoController : Controller
    {
        #region Páginas

        // GET: Contato
        public ActionResult Index()
        {
            return View();
        }

        #endregion

        #region Métodos

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EnviarContato(ViewModelContato viewModelContato)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    Contato contato = new Contato();
                    contato.Email = viewModelContato.Email;
                    contato.Assunto = viewModelContato.Assunto;
                    contato.Mensagem = viewModelContato.Mensagem;

                    Mail.Email.Mail.SendMail(contato);
                    ViewBag.Mensagem = "Mensagem enviada com sucesso.";
                }
                catch (Exception ex)
                {
                    throw new Exception("Ocorreu o seguinte erro ao tentar enviar a mensagem: " + ex.Message);
                }
            }
            return View("Index");
        }

        #endregion
    }
}