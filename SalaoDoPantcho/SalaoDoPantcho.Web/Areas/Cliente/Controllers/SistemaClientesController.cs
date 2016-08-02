using System;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Web.Security;
using SalaoDoPantcho.App.IContractsAppServices.IContractsAppServicesEntity.IContractsAppServicesClientes;
using SalaoDoPantcho.App.IContractsAppServices.IContractsAppServicesEntity.IContractsAppServicesEnderecosClientes;
using SalaoDoPantcho.App.IContractsAppServices.IContractsAppServicesEntity.IContractsAppServicesTelefonesClientes;
using SalaoDoPantcho.Entity.Sistema.Entity;
using SalaoDoPantcho.Entity.Sistema.Enum;
using SalaoDoPantcho.Web.Areas.Cliente.Models;
using SalaoDoPantcho.Security.CriptographyPasswords;
using SalaoDoPantcho.Convert.Strings;

namespace SalaoDoPantcho.Web.Areas.Cliente.Controllers
{
    
    public class SistemaClientesController : Controller
    {
        #region Propriedades

        private IContractsAppServicesCliente appServicesCliente;
        private IContractsAppServicesEnderecosCliente appServicesEnderecoCliente;
        private IContractsAppServicesTelefonesCliente appServicesTelefoneCliente;

        #endregion

        #region Construtor

        public SistemaClientesController(IContractsAppServicesCliente appServicesCliente, IContractsAppServicesEnderecosCliente appServicesEnderecoCliente, IContractsAppServicesTelefonesCliente appServicesTelefoneCliente)
        {
            this.appServicesCliente = appServicesCliente;
            this.appServicesEnderecoCliente = appServicesEnderecoCliente;
            this.appServicesTelefoneCliente = appServicesTelefoneCliente;
        }

        #endregion

        #region Páginas

        // Geral...

        public ActionResult Index()
        {
            Clientes clienteSession = (Clientes)Session["cliente"];
            if (clienteSession != null)
            {
                if (HttpContext.User.Identity.IsAuthenticated)
                {
                    ViewBag.Nome = clienteSession.Nome;
                    ViewBag.Login = clienteSession.Login;
                    if (clienteSession.Perfil == Perfil.Cliente)
                    {
                        ViewBag.Perfil = "Cliente";
                    }
                    if (clienteSession.Login == clienteSession.Senha)
                    {
                        TempData["MensagemAviso"] = "Login e Senha iguais. Troque sua senha em Trocar Senha.";
                    }
                    else
                    {
                        TempData["MensagemAviso"] = string.Empty;
                    }
                    return View("Index");
                }
                else
                {
                    return RedirectToAction("Index", "Home", new { area = "" });
                }
            }
            else
            {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
        }

        public ActionResult CuidadosContaAcesso()
        {
            Clientes clienteSession = (Clientes)Session["cliente"];
            if (clienteSession != null)
            {
                if (HttpContext.User.Identity.IsAuthenticated)
                {
                    ViewBag.Nome = clienteSession.Nome;
                    ViewBag.Login = clienteSession.Login;
                    if (clienteSession.Perfil == Perfil.Cliente)
                    {
                        ViewBag.Perfil = "Cliente";
                    }
                    if (clienteSession.Login == clienteSession.Senha)
                    {
                        TempData["MensagemAviso"] = "Login e Senha iguais. Troque sua senha em Trocar Senha.";
                    }
                    else
                    {
                        TempData["MensagemAviso"] = string.Empty;
                    }
                    return View("CuidadosContaAcesso");
                }
                else
                {
                    return RedirectToAction("Index", "Home", new { area = "" });
                }
            }
            else
            {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
        }

        public ActionResult ListaOperacoes()
        {
            Clientes clienteSession = (Clientes)Session["cliente"];
            if (clienteSession != null)
            {
                if (HttpContext.User.Identity.IsAuthenticated)
                {
                    ViewBag.Nome = clienteSession.Nome;
                    ViewBag.Login = clienteSession.Login;
                    if (clienteSession.Perfil == Perfil.Cliente)
                    {
                        ViewBag.Perfil = "Cliente";
                    }
                    if (clienteSession.Login == clienteSession.Senha)
                    {
                        TempData["MensagemAviso"] = "Login e Senha iguais. Troque sua senha em Trocar Senha.";
                    }
                    else
                    {
                        TempData["MensagemAviso"] = string.Empty;
                    }
                    return View("ListaOperacoes");
                }
                else
                {
                    return RedirectToAction("Index", "Home", new { area = "" });
                }
            }
            else
            {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
        }

        // Serviços...

        public ActionResult Atualizacao()
        {
            Clientes clienteSession = (Clientes)Session["cliente"];
            if (clienteSession != null)
            {
                if (HttpContext.User.Identity.IsAuthenticated)
                {
                    ViewBag.Nome = clienteSession.Nome;
                    ViewBag.Login = clienteSession.Login;
                    if (clienteSession.Perfil == Perfil.Cliente)
                    {
                        ViewBag.Perfil = "Cliente";
                    }
                    if (clienteSession.Login == clienteSession.Senha)
                    {
                        TempData["MensagemAviso"] = "Login e Senha iguais. Troque sua senha em Trocar Senha.";
                    }
                    else
                    {
                        TempData["MensagemAviso"] = string.Empty;
                    }
                    return View("Atualizacao");
                }
                else
                {
                    return RedirectToAction("Index", "Home", new { area = "" });
                }
            }
            else
            {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
        }

        public ActionResult TrocaSenha()
        {
            Clientes clienteSession = (Clientes)Session["cliente"];
            if (clienteSession != null)
            {
                if (HttpContext.User.Identity.IsAuthenticated)
                {
                    ViewBag.Nome = clienteSession.Nome;
                    ViewBag.Login = clienteSession.Login;
                    if (clienteSession.Perfil == Perfil.Cliente)
                    {
                        ViewBag.Perfil = "Cliente";
                    }
                    if (clienteSession.Login == clienteSession.Senha)
                    {
                        TempData["MensagemAviso"] = "Login e Senha iguais. Troque sua senha em Trocar Senha.";
                    }
                    else
                    {
                        TempData["MensagemAviso"] = string.Empty;
                    }
                }
                else
                {
                    return RedirectToAction("Index", "Home", new { area = "" });
                }
            }
            else
            {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            return View();
        }

        public ActionResult AtivaDesativa()
        {
            return View();
        }

        // Pesquisa Cliente...

        public ActionResult PesquisaClientePorLoginEmail()
        {
            Clientes clienteSession = (Clientes)Session["cliente"];
            if (clienteSession != null)
            {
                if (HttpContext.User.Identity.IsAuthenticated)
                {
                    ViewBag.Nome = clienteSession.Nome;
                    ViewBag.Login = clienteSession.Login;
                    if (clienteSession.Perfil == Perfil.Cliente)
                    {
                        ViewBag.Perfil = "Cliente";
                    }
                    if (clienteSession.Login == clienteSession.Senha)
                    {
                        TempData["MensagemAviso"] = "Login e Senha iguais. Troque sua senha em Trocar Senha.";
                    }
                    else
                    {
                        TempData["MensagemAviso"] = string.Empty;
                    }
                }
                else
                {
                    return RedirectToAction("Index", "Home", new { area = "" });
                }
            }
            else
            {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            return View();
        }

        public ActionResult PesquisaClientePorLoginSenha()
        {
            Clientes clienteSession = (Clientes)Session["cliente"];
            if (clienteSession != null)
            {
                if (HttpContext.User.Identity.IsAuthenticated)
                {
                    ViewBag.Nome = clienteSession.Nome;
                    ViewBag.Login = clienteSession.Login;
                    if (clienteSession.Perfil == Perfil.Cliente)
                    {
                        ViewBag.Perfil = "Cliente";
                    }
                    if (clienteSession.Login == clienteSession.Senha)
                    {
                        TempData["MensagemAviso"] = "Login e Senha iguais. Troque sua senha em Trocar Senha.";
                    }
                    else
                    {
                        TempData["MensagemAviso"] = string.Empty;
                    }
                }
                else
                {
                    return RedirectToAction("Index", "Home", new { area = "" });
                }
            }
            else
            {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            return View();
        }

        public ActionResult PesquisaClientePorNomeApelidoEmail()
        {
            Clientes clienteSession = (Clientes)Session["cliente"];
            if (clienteSession != null)
            {
                if (HttpContext.User.Identity.IsAuthenticated)
                {
                    ViewBag.Nome = clienteSession.Nome;
                    ViewBag.Login = clienteSession.Login;
                    if (clienteSession.Perfil == Perfil.Cliente)
                    {
                        ViewBag.Perfil = "Cliente";
                    }
                    if (clienteSession.Login == clienteSession.Senha)
                    {
                        TempData["MensagemAviso"] = "Login e Senha iguais. Troque sua senha em Trocar Senha.";
                    }
                    else
                    {
                        TempData["MensagemAviso"] = string.Empty;
                    }
                }
                else
                {
                    return RedirectToAction("Index", "Home", new { area = "" });
                }
            }
            else
            {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            return View();
        }

        // Pesquisa Endereço...

        public ActionResult PesquisaEnderecoPorCep()
        {
            Clientes clienteSession = (Clientes)Session["cliente"];
            if (clienteSession != null)
            {
                if (HttpContext.User.Identity.IsAuthenticated)
                {
                    ViewBag.Nome = clienteSession.Nome;
                    ViewBag.Login = clienteSession.Login;
                    if (clienteSession.Perfil == Perfil.Cliente)
                    {
                        ViewBag.Perfil = "Cliente";
                    }
                    if (clienteSession.Login == clienteSession.Senha)
                    {
                        TempData["MensagemAviso"] = "Login e Senha iguais. Troque sua senha em Trocar Senha.";
                    }
                    else
                    {
                        TempData["MensagemAviso"] = string.Empty;
                    }
                }
                else
                {
                    return RedirectToAction("Index", "Home", new { area = "" });
                }
            }
            else
            {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            return View();
        }

        public ActionResult PesquisaEnderecoPorBairro()
        {
            Clientes clienteSession = (Clientes)Session["cliente"];
            if (clienteSession != null)
            {
                if (HttpContext.User.Identity.IsAuthenticated)
                {
                    ViewBag.Nome = clienteSession.Nome;
                    ViewBag.Login = clienteSession.Login;
                    if (clienteSession.Perfil == Perfil.Cliente)
                    {
                        ViewBag.Perfil = "Cliente";
                    }
                    if (clienteSession.Login == clienteSession.Senha)
                    {
                        TempData["MensagemAviso"] = "Login e Senha iguais. Troque sua senha em Trocar Senha.";
                    }
                    else
                    {
                        TempData["MensagemAviso"] = string.Empty;
                    }
                }
                else
                {
                    return RedirectToAction("Index", "Home", new { area = "" });
                }
            }
            else
            {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            return View();
        }

        public ActionResult PesquisaEnderecoPorTipoEndereco()
        {
            Clientes clienteSession = (Clientes)Session["cliente"];
            if (clienteSession != null)
            {
                if (HttpContext.User.Identity.IsAuthenticated)
                {
                    ViewBag.Nome = clienteSession.Nome;
                    ViewBag.Login = clienteSession.Login;
                    if (clienteSession.Perfil == Perfil.Cliente)
                    {
                        ViewBag.Perfil = "Cliente";
                    }
                    if (clienteSession.Login == clienteSession.Senha)
                    {
                        TempData["MensagemAviso"] = "Login e Senha iguais. Troque sua senha em Trocar Senha.";
                    }
                    else
                    {
                        TempData["MensagemAviso"] = string.Empty;
                    }
                }
                else
                {
                    return RedirectToAction("Index", "Home", new { area = "" });
                }
            }
            else
            {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            return View();
        }

        // Pesquisa Telefone...

        public ActionResult PesquisaTelefonePorDDD()
        {
            Clientes clienteSession = (Clientes)Session["cliente"];
            if (clienteSession != null)
            {
                if (HttpContext.User.Identity.IsAuthenticated)
                {
                    ViewBag.Nome = clienteSession.Nome;
                    ViewBag.Login = clienteSession.Login;
                    if (clienteSession.Perfil == Perfil.Cliente)
                    {
                        ViewBag.Perfil = "Cliente";
                    }
                    if (clienteSession.Login == clienteSession.Senha)
                    {
                        TempData["MensagemAviso"] = "Login e Senha iguais. Troque sua senha em Trocar Senha.";
                    }
                    else
                    {
                        TempData["MensagemAviso"] = string.Empty;
                    }
                }
                else
                {
                    return RedirectToAction("Index", "Home", new { area = "" });
                }
            }
            else
            {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            return View();
        }

        public ActionResult PesquisaTelefonePorNumero()
        {
            Clientes clienteSession = (Clientes)Session["cliente"];
            if (clienteSession != null)
            {
                if (HttpContext.User.Identity.IsAuthenticated)
                {
                    ViewBag.Nome = clienteSession.Nome;
                    ViewBag.Login = clienteSession.Login;
                    if (clienteSession.Perfil == Perfil.Cliente)
                    {
                        ViewBag.Perfil = "Cliente";
                    }
                    if (clienteSession.Login == clienteSession.Senha)
                    {
                        TempData["MensagemAviso"] = "Login e Senha iguais. Troque sua senha em Trocar Senha.";
                    }
                    else
                    {
                        TempData["MensagemAviso"] = string.Empty;
                    }
                }
                else
                {
                    return RedirectToAction("Index", "Home", new { area = "" });
                }
            }
            else
            {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            return View();
        }

        public ActionResult PesquisaTelefonePorTipoTelefone()
        {
            Clientes clienteSession = (Clientes)Session["cliente"];
            if (clienteSession != null)
            {
                if (HttpContext.User.Identity.IsAuthenticated)
                {
                    ViewBag.Nome = clienteSession.Nome;
                    ViewBag.Login = clienteSession.Login;
                    if (clienteSession.Perfil == Perfil.Cliente)
                    {
                        ViewBag.Perfil = "Cliente";
                    }
                    if (clienteSession.Login == clienteSession.Senha)
                    {
                        TempData["MensagemAviso"] = "Login e Senha iguais. Troque sua senha em Trocar Senha.";
                    }
                    else
                    {
                        TempData["MensagemAviso"] = string.Empty;
                    }
                }
                else
                {
                    return RedirectToAction("Index", "Home", new { area = "" });
                }
            }
            else
            {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            return View();
        }

        #endregion

        #region Métodos

        // cliente...

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AtualizarCliente(ViewModelClientesAtualizar modelAtualizarCliente)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Clientes cliente = new Clientes();
                    TelefonesCliente telefone = new TelefonesCliente();
                    cliente.EnderecosCliente = new EnderecosCliente();
                    cliente.TelefonesCliente = new List<TelefonesCliente>();
                    //cliente.EnderecosCliente = Mapper.Map<ViewModelClientesInserir, EnderecosCliente>(modelInserirCliente);

                    cliente.Apelido = modelAtualizarCliente.Apelido;
                    cliente.DataAlteracao = DateTime.Now.Date;
                    cliente.Email = modelAtualizarCliente.Email;
                    cliente.GeneroSexo = modelAtualizarCliente.Genero;
                    cliente.Login = modelAtualizarCliente.Login;
                    cliente.Nome = modelAtualizarCliente.Nome;
                    cliente.Perfil = Perfil.Cliente;
                    cliente.StatusPessoa = StatusPessoa.Ativo;
                    cliente.Senha = CriptographyPassword.CriptografarSenha(modelAtualizarCliente.Senha);

                    cliente.EnderecosCliente.Bairro = modelAtualizarCliente.Bairro;
                    cliente.EnderecosCliente.CEP = modelAtualizarCliente.Cep;
                    cliente.EnderecosCliente.Complemento = modelAtualizarCliente.Complemento;
                    cliente.EnderecosCliente.DataAlteracao = DateTime.Now.Date;
                    cliente.EnderecosCliente.Descricao = modelAtualizarCliente.Descricao;
                    cliente.EnderecosCliente.Numero = modelAtualizarCliente.NumeroEnd;
                    cliente.EnderecosCliente.TipoEndereco = modelAtualizarCliente.TipoEndereco;

                    telefone.DataAlteracao = DateTime.Now.Date;
                    telefone.DDD = modelAtualizarCliente.DDD;
                    telefone.Numero = modelAtualizarCliente.NumeroTel;
                    telefone.TipoTelefone = modelAtualizarCliente.TipoTelefone;

                    cliente.TelefonesCliente.Add(telefone);
                    cliente = ConvertionStrings.ConverterStringsClienteToLower(cliente);
                    appServicesCliente.AppServicesAtualizar(cliente);

                    TempData["MensagemSucesso"] = "Seu cadastro foi atualizado com sucesso.";
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            return View("Atualizacao");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TrocarSenhaCliente(ViewModelClienteTrocarSenha viewModelClienteTrocarSenha)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    if (viewModelClienteTrocarSenha.Login == viewModelClienteTrocarSenha.SenhaAtual && viewModelClienteTrocarSenha.SenhaAtual == viewModelClienteTrocarSenha.NovaSenha)
                    {
                        TempData["MensagemErro"] = "Sua nova Senha não poderá ser a mesma senha que está resetada pelo sistema. Escolha outra senha.";
                    }
                    else
                    {
                        if (viewModelClienteTrocarSenha.Login == viewModelClienteTrocarSenha.SenhaAtual) // Senha resetada...
                        {
                            Clientes cliente = appServicesCliente.AppServicesPesquisarClientePorLoginSenha(viewModelClienteTrocarSenha.Login, viewModelClienteTrocarSenha.SenhaAtual);
                            if (cliente != null)
                            {
                                appServicesCliente.AppTrocarSenha(viewModelClienteTrocarSenha.SenhaAtual, CriptographyPassword.CriptografarSenha(viewModelClienteTrocarSenha.NovaSenha));
                                TempData["MensagemSucesso"] = "Sua Senha foi alterada com sucesso.";
                            }
                            else
                            {
                                TempData["MensagemErro"] = "Cliente " + viewModelClienteTrocarSenha.Login + " não foi encontrado.";
                            }
                        }
                        else // Senha não resetada...
                        {
                            Clientes cliente = appServicesCliente.AppServicesPesquisarClientePorLoginSenha(viewModelClienteTrocarSenha.Login, CriptographyPassword.CriptografarSenha(viewModelClienteTrocarSenha.SenhaAtual));
                            if (cliente != null)
                            {
                                appServicesCliente.AppTrocarSenha(viewModelClienteTrocarSenha.SenhaAtual, CriptographyPassword.CriptografarSenha(viewModelClienteTrocarSenha.NovaSenha));
                                TempData["MensagemSucesso"] = "Sua Senha foi alterada com sucesso.";
                            }
                            else
                            {
                                TempData["MensagemErro"] = "Cliente " + viewModelClienteTrocarSenha.Login + " não foi encontrado.";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            return View("TrocaSenha");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AtivarDesativarCliente(ViewModelClienteAtivarDesativar viewModelClienteAtivarDesativar)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if(viewModelClienteAtivarDesativar.Login == viewModelClienteAtivarDesativar.Senha)
                    {
                        TempData["MensagemErro"] = "Para Ativar/Desativar eu Status é necessário Trocar sua Senha.";
                    }
                    else
                    {
                        Clientes cliente = appServicesCliente.AppServicesPesquisarClientePorLoginSenha(viewModelClienteAtivarDesativar.Login, CriptographyPassword.CriptografarSenha(viewModelClienteAtivarDesativar.Senha));
                        if (cliente != null)
                        {
                            if (viewModelClienteAtivarDesativar.StatusCliente == StatusPessoa.Ativo)
                            {
                                appServicesCliente.AppAtivarCliente(cliente.Login, cliente.Senha, cliente.StatusPessoa);
                                TempData["MensagemSucesso"] = "Seu Status foi Ativado com sucesso.";
                            }
                            if (viewModelClienteAtivarDesativar.StatusCliente == StatusPessoa.Inativo)
                            {
                                appServicesCliente.AppDesativarCliente(cliente.Login, cliente.Senha, cliente.StatusPessoa);
                                TempData["MensagemSucesso"] = "Seu Status foi Desativado com sucesso.";
                            }
                        }
                        else
                        {
                            TempData["MensagemErro"] = "Cliente " + cliente.Login + " não foi encontrado.";
                        }
                    }                    
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            return View("AtivaDesativa");
        }

        [HttpGet]
        public ActionResult PesquisarClientePorLoginEmail(ViewModelPesquisaCliente viewModelPesquisaCliente)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    Clientes cliente = appServicesCliente.AppServicesPesquisarClientePorLoginEmail(viewModelPesquisaCliente.Login, viewModelPesquisaCliente.Email);
                    if (cliente != null)
                    {
                        viewModelPesquisaCliente.Apelido = cliente.Apelido;
                        viewModelPesquisaCliente.Nome = cliente.Nome;
                        viewModelPesquisaCliente.Email = cliente.Email;
                        viewModelPesquisaCliente.Login = cliente.Login;
                        viewModelPesquisaCliente.GeneroCliente = cliente.GeneroSexo;
                        viewModelPesquisaCliente.Login = cliente.Login;
                        viewModelPesquisaCliente.PerfilCliente = cliente.Perfil;
                        viewModelPesquisaCliente.StatusPessoa = cliente.StatusPessoa;
                        return View("PesquisaClientePorLoginEmail", viewModelPesquisaCliente);
                    }
                    else
                    {
                        TempData["MensagemErro"] = "Dados do Cliente não foram encontrados. Tente mais tarde.";
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            return View("PesquisaClientePorLoginEmail");
        }

        [HttpGet]
        public ActionResult PesquisarClientePorLoginSenha(ViewModelPesquisaCliente viewModelPesquisaCliente)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Clientes cliente = appServicesCliente.AppServicesPesquisarClientePorLoginEmail(viewModelPesquisaCliente.Login, viewModelPesquisaCliente.Email);
                    if (cliente != null)
                    {
                        viewModelPesquisaCliente.Apelido = cliente.Apelido;
                        viewModelPesquisaCliente.Nome = cliente.Nome;
                        viewModelPesquisaCliente.Email = cliente.Email;
                        viewModelPesquisaCliente.Login = cliente.Login;
                        viewModelPesquisaCliente.GeneroCliente = cliente.GeneroSexo;
                        viewModelPesquisaCliente.Login = cliente.Login;
                        viewModelPesquisaCliente.PerfilCliente = cliente.Perfil;
                        viewModelPesquisaCliente.StatusPessoa = cliente.StatusPessoa;
                        return View("PesquisaClientePorLoginEmail", viewModelPesquisaCliente);
                    }
                    else
                    {
                        TempData["MensagemErro"] = "Dados do Cliente não foram encontrados. Tente mais tarde.";
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            return View("PesquisaClientePorLoginEmail");
        }

        [HttpGet]
        public ActionResult PesquisarClientePorNomeApelidoEmail(ViewModelPesquisaCliente viewModelPesquisaCliente)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Clientes clientePorNomeEmail = appServicesCliente.AppServicesPesquisarClientePorNomeApelidoEmail(viewModelPesquisaCliente.Nomeapelido, viewModelPesquisaCliente.Email);
                    if (clientePorNomeEmail != null)
                    {
                        viewModelPesquisaCliente.Apelido = clientePorNomeEmail.Apelido;
                        viewModelPesquisaCliente.Nome = clientePorNomeEmail.Nome;
                        viewModelPesquisaCliente.Email = clientePorNomeEmail.Email;
                        viewModelPesquisaCliente.Login = clientePorNomeEmail.Login;
                        viewModelPesquisaCliente.GeneroCliente = clientePorNomeEmail.GeneroSexo;
                        viewModelPesquisaCliente.Login = clientePorNomeEmail.Login;
                        viewModelPesquisaCliente.PerfilCliente = clientePorNomeEmail.Perfil;
                        viewModelPesquisaCliente.StatusPessoa = clientePorNomeEmail.StatusPessoa;
                        return View("PesquisaClientePorLoginEmail", viewModelPesquisaCliente);
                    }
                    Clientes clientePorApelidoEmail = appServicesCliente.AppServicesPesquisarClientePorNomeApelidoEmail(viewModelPesquisaCliente.Nomeapelido, viewModelPesquisaCliente.Email);
                    if (clientePorApelidoEmail != null)
                    {
                        viewModelPesquisaCliente.Apelido = clientePorApelidoEmail.Apelido;
                        viewModelPesquisaCliente.Nome = clientePorApelidoEmail.Nome;
                        viewModelPesquisaCliente.Email = clientePorApelidoEmail.Email;
                        viewModelPesquisaCliente.Login = clientePorApelidoEmail.Login;
                        viewModelPesquisaCliente.GeneroCliente = clientePorApelidoEmail.GeneroSexo;
                        viewModelPesquisaCliente.Login = clientePorApelidoEmail.Login;
                        viewModelPesquisaCliente.PerfilCliente = clientePorApelidoEmail.Perfil;
                        viewModelPesquisaCliente.StatusPessoa = clientePorApelidoEmail.StatusPessoa;
                        return View("PesquisaClientePorLoginEmail", viewModelPesquisaCliente);
                    }
                    else
                    {
                        TempData["MensagemErro"] = "Dados do Cliente não foram encontrados. Tente mais tarde.";
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            return View("PesquisaClientePorLoginEmail");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Sair()
        {
            FormsAuthentication.SignOut();
            Session.Remove("cliente");
            Session.Abandon();
            return RedirectToAction("Index", "Home", new { area = "" });
        }

        // Endereço...

        [HttpGet]
        public ActionResult PesquisarEnderecoPorCep(ViewModelPesquisaEndereco viewModelPesquisaEndereco)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if(string.IsNullOrEmpty(viewModelPesquisaEndereco.Cep))
                    {
                        TempData["MensagemErro"] = "Não foi possível pesquisar o Endereço do Cliente pelo Cep. Informe o Cep válido.";
                    }
                    else
                    {
                        Clientes cliente = new Clientes();
                        cliente.EnderecosCliente = appServicesEnderecoCliente.AppServicePesquisarEnderecoPorCep(viewModelPesquisaEndereco.Cep);
                        if(cliente.EnderecosCliente != null)
                        {
                            cliente = appServicesCliente.AppServicesPesquisarPorId(cliente.EnderecosCliente.IdEnderecoCli);
                            if (cliente.EnderecosCliente != null && cliente != null)
                            {
                                if (cliente.EnderecosCliente.IdEnderecoCli == cliente.IdEnderecoCli)
                                {
                                    viewModelPesquisaEndereco.Descricao = cliente.EnderecosCliente.Descricao;
                                    viewModelPesquisaEndereco.NumeroEnd = cliente.EnderecosCliente.Numero;
                                    viewModelPesquisaEndereco.Complemento = cliente.EnderecosCliente.Complemento;
                                    viewModelPesquisaEndereco.Bairro = cliente.EnderecosCliente.Bairro;
                                    viewModelPesquisaEndereco.Cep = cliente.EnderecosCliente.CEP;
                                    viewModelPesquisaEndereco.TipoEndereco = cliente.EnderecosCliente.TipoEndereco;
                                    return View("PesquisaEnderecoPorCep", viewModelPesquisaEndereco);
                                }
                                else
                                {
                                    TempData["MensagemErro"] = "Dados do Endereço do Cliente não estão consistentes e/ou relacionados.";
                                }
                            }
                            else
                            {
                                TempData["MensagemErro"] = "Dados do Endereço do Cliente não foram encontrados. Tente mais tarde.";
                            }
                        }
                        else
                        {
                            TempData["MensagemErro"] = "Não foi possível pesquisar o Endereço do Cliente pelo Cep. Informe o Cep válido.";
                        }
                    }                    
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            return View("PesquisaEnderecoPorCep");
        }

        [HttpGet]
        public ActionResult PesquisarEnderecoPorBairro(ViewModelPesquisaEndereco viewModelPesquisaEndereco)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (string.IsNullOrEmpty(viewModelPesquisaEndereco.Bairro))
                    {
                        TempData["MensagemErro"] = "Não foi possível pesquisar o Endereço do Cliente pelo Bairro. Informe o Bairro válido.";
                    }
                    else
                    {
                        Clientes cliente = new Clientes();
                        cliente.EnderecosCliente = appServicesEnderecoCliente.AppServicePesquisarEnderecoPorBairro(viewModelPesquisaEndereco.Bairro);
                        if (cliente.EnderecosCliente != null)
                        {
                            cliente = appServicesCliente.AppServicesPesquisarPorId(cliente.EnderecosCliente.IdEnderecoCli);
                            if (cliente.EnderecosCliente != null && cliente != null)
                            {
                                if (cliente.EnderecosCliente.IdEnderecoCli == cliente.IdEnderecoCli)
                                {
                                    viewModelPesquisaEndereco.Descricao = cliente.EnderecosCliente.Descricao;
                                    viewModelPesquisaEndereco.NumeroEnd = cliente.EnderecosCliente.Numero;
                                    viewModelPesquisaEndereco.Complemento = cliente.EnderecosCliente.Complemento;
                                    viewModelPesquisaEndereco.Bairro = cliente.EnderecosCliente.Bairro;
                                    viewModelPesquisaEndereco.Cep = cliente.EnderecosCliente.CEP;
                                    viewModelPesquisaEndereco.TipoEndereco = cliente.EnderecosCliente.TipoEndereco;
                                    return View("PesquisaEnderecoPorBairro", viewModelPesquisaEndereco);
                                }
                                else
                                {
                                    TempData["MensagemErro"] = "Dados do Endereço do Cliente não estão consistentes e/ou relacionados.";
                                }
                            }
                            else
                            {
                                TempData["MensagemErro"] = "Dados do Endereço do Cliente não foram encontrados. Tente mais tarde.";
                            }
                        }
                        else
                        {
                            TempData["MensagemErro"] = "Não foi possível pesquisar o Endereço do Cliente pelo Bairro. Informe o Bairro válido.";
                        }
                    }                    
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            return View("PesquisaEnderecoPorBairro");
        }

        [HttpGet]
        public ActionResult PesquisarEnderecoPorTipoEndereco(ViewModelPesquisaEndereco viewModelPesquisaEndereco)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (string.IsNullOrEmpty(viewModelPesquisaEndereco.TipoEndereco.ToString()))
                    {
                        TempData["MensagemErro"] = "Não foi possível pesquisar o Endereço do Cliente pelo Tipo de Endereço. Informe o Tipo de Endereço válido.";
                    }
                    else
                    {
                        Clientes cliente = new Clientes();
                        cliente.EnderecosCliente = appServicesEnderecoCliente.AppServicePesquisarEnderecoPorTipoEndereco(viewModelPesquisaEndereco.TipoEndereco);
                        if (cliente.EnderecosCliente != null)
                        {
                            cliente = appServicesCliente.AppServicesPesquisarPorId(cliente.EnderecosCliente.IdEnderecoCli);
                            if (cliente.EnderecosCliente != null && cliente != null)
                            {
                                if (cliente.EnderecosCliente.IdEnderecoCli == cliente.IdEnderecoCli)
                                {
                                    viewModelPesquisaEndereco.Descricao = cliente.EnderecosCliente.Descricao;
                                    viewModelPesquisaEndereco.NumeroEnd = cliente.EnderecosCliente.Numero;
                                    viewModelPesquisaEndereco.Complemento = cliente.EnderecosCliente.Complemento;
                                    viewModelPesquisaEndereco.Bairro = cliente.EnderecosCliente.Bairro;
                                    viewModelPesquisaEndereco.Cep = cliente.EnderecosCliente.CEP;
                                    viewModelPesquisaEndereco.TipoEndereco = cliente.EnderecosCliente.TipoEndereco;
                                    return View("PesquisaEnderecoPorTipoEndereco", viewModelPesquisaEndereco);
                                }
                                else
                                {
                                    TempData["MensagemErro"] = "Dados do Endereço do Cliente não estão consistentes e/ou relacionados.";
                                }
                            }
                            else
                            {
                                TempData["MensagemErro"] = "Dados do Endereço do Cliente não foram encontrados. Tente mais tarde.";
                            }
                        }
                        else
                        {
                            TempData["MensagemErro"] = "Não foi possível pesquisar o Endereço do Cliente pelo Tipo de Endereço. Informe o Tipo de Endereço válido.";
                        }
                    }                    
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            return View("PesquisaEnderecoPorTipoEndereco");
        }

        // Contato...

        [HttpGet]
        public ActionResult PesquisarTelefonePorDDD(ViewModelPesquisaTelefone viewModelPesquisaTelefone)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (string.IsNullOrEmpty(viewModelPesquisaTelefone.DDD.ToString()))
                    {
                        TempData["MensagemErro"] = "Não foi possível pesquisar o Telefone do Cliente pelo DDD. Informe o DDD válido.";
                    }
                    else
                    {
                        Clientes cliente = new Clientes();
                        TelefonesCliente telefoneCliente = new TelefonesCliente();
                        telefoneCliente = appServicesTelefoneCliente.AppServicesPesquisarTelefonePorDDD(viewModelPesquisaTelefone.DDD);
                        if (telefoneCliente != null)
                        {
                            cliente.TelefonesCliente = new List<TelefonesCliente>();
                            cliente.TelefonesCliente.Add(telefoneCliente);
                            cliente = appServicesCliente.AppServicesPesquisarPorId(telefoneCliente.IdCliente);
                            if (cliente.TelefonesCliente != null && cliente != null)
                            {
                                if (cliente.IdCliente == telefoneCliente.IdCliente)
                                {
                                    viewModelPesquisaTelefone.DDD = telefoneCliente.DDD;
                                    viewModelPesquisaTelefone.NumeroTel = telefoneCliente.Numero;
                                    viewModelPesquisaTelefone.TipoTelefone = telefoneCliente.TipoTelefone;
                                    return View("PesquisaTelefonePorDDD", viewModelPesquisaTelefone);
                                }
                                else
                                {
                                    TempData["MensagemErro"] = "Dados do Telefone do Cliente não estão consistentes e/ou relacionados.";
                                }
                            }
                            else
                            {
                                TempData["MensagemErro"] = "Dados do Telefone do Cliente não foram encontrados. Tente mais tarde.";
                            }
                        }
                        else
                        {
                            TempData["MensagemErro"] = "Não foi possível pesquisar o Telefone do Cliente pelo DDD. Informe o DDD válido.";
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            return View("PesquisaTelefonePorDDD");
        }

        [HttpGet]
        public ActionResult PesquisarTelefonePorNumero(ViewModelPesquisaTelefone viewModelPesquisaTelefone)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (string.IsNullOrEmpty(viewModelPesquisaTelefone.DDD.ToString()))
                    {
                        TempData["MensagemErro"] = "Não foi possível pesquisar o Telefone do Cliente pelo Número. Informe o Número do Telefone válido.";
                    }
                    else
                    {
                        Clientes cliente = new Clientes();
                        TelefonesCliente telefoneCliente = new TelefonesCliente();
                        telefoneCliente = appServicesTelefoneCliente.AppServicesPesquisarTelefonePorNumero(viewModelPesquisaTelefone.NumeroTel);
                        if (telefoneCliente != null)
                        {
                            cliente.TelefonesCliente = new List<TelefonesCliente>();
                            cliente.TelefonesCliente.Add(telefoneCliente);
                            cliente = appServicesCliente.AppServicesPesquisarPorId(telefoneCliente.IdCliente);
                            if (cliente.TelefonesCliente != null && cliente != null)
                            {
                                if (cliente.IdCliente == telefoneCliente.IdCliente)
                                {
                                    viewModelPesquisaTelefone.DDD = telefoneCliente.DDD;
                                    viewModelPesquisaTelefone.NumeroTel = telefoneCliente.Numero;
                                    viewModelPesquisaTelefone.TipoTelefone = telefoneCliente.TipoTelefone;
                                    return View("PesquisaTelefonePorTipoTelefone", viewModelPesquisaTelefone);
                                }
                                else
                                {
                                    TempData["MensagemErro"] = "Dados do Telefone do Cliente não estão consistentes e/ou relacionados.";
                                }
                            }
                            else
                            {
                                TempData["MensagemErro"] = "Dados do Telefone do Cliente não foram encontrados. Tente mais tarde.";
                            }
                        }
                        else
                        {
                            TempData["MensagemErro"] = "Não foi possível pesquisar o Telefone do Cliente pelo Número. Informe o Número do Telefone válido.";
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            return View("PesquisaTelefonePorTipoTelefone");
        }

        [HttpGet]
        public ActionResult PesquisarTelefonePorTipoTelefone(ViewModelPesquisaTelefone viewModelPesquisaTelefone)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (string.IsNullOrEmpty(viewModelPesquisaTelefone.TipoTelefone.ToString()))
                    {
                        TempData["MensagemErro"] = "Não foi possível pesquisar o Telefone do Cliente pelo Tipo de Telefone. Informe o Tipo de Telefone válido.";
                    }
                    else
                    {
                        Clientes cliente = new Clientes();
                        TelefonesCliente telefoneCliente = new TelefonesCliente();
                        telefoneCliente = appServicesTelefoneCliente.AppServicesPesquisarTelefonePorTipoTelefone(viewModelPesquisaTelefone.TipoTelefone);
                        if (telefoneCliente != null)
                        {
                            cliente.TelefonesCliente = new List<TelefonesCliente>();
                            cliente.TelefonesCliente.Add(telefoneCliente);
                            cliente = appServicesCliente.AppServicesPesquisarPorId(telefoneCliente.IdCliente);
                            if (cliente.TelefonesCliente != null && cliente != null)
                            {
                                if (cliente.IdCliente == telefoneCliente.IdCliente)
                                {
                                    viewModelPesquisaTelefone.DDD = telefoneCliente.DDD;
                                    viewModelPesquisaTelefone.NumeroTel = telefoneCliente.Numero;
                                    viewModelPesquisaTelefone.TipoTelefone = telefoneCliente.TipoTelefone;
                                    return View("PesquisaTelefonePorTipoTelefone", viewModelPesquisaTelefone);
                                }
                                else
                                {
                                    TempData["MensagemErro"] = "Dados do Telefone do Cliente não estão consistentes e/ou relacionados.";
                                }
                            }
                            else
                            {
                                TempData["MensagemErro"] = "Dados do Telefone do Cliente não foram encontrados. Tente mais tarde.";
                            }
                        }
                        else
                        {
                            TempData["MensagemErro"] = "Não foi possível pesquisar o Telefone do Cliente pelo Tipo de Telefone. Informe o Tipo de Telefone válido.";
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            return View("PesquisaTelefonePorTipoTelefone");
        }

        #endregion
    }
}