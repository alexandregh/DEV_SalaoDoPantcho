using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Security;
using SalaoDoPantcho.App.IContractsAppServices.IContractsAppServicesEntity.IContractsAppServicesClientes;
using SalaoDoPantcho.Web.Models.Sistema.Clientes;
using SalaoDoPantcho.Entity.Sistema.Entity;
using SalaoDoPantcho.Security.CriptographyPasswords;
using SalaoDoPantcho.App.IContractsAppServices.IContractsAppServicesEntity.IContractsAppServicesTelefonesClientes;
using SalaoDoPantcho.App.IContractsAppServices.IContractsAppServicesEntity.IContractsAppServicesEnderecosClientes;
using SalaoDoPantcho.Convert.Strings;
using SalaoDoPantcho.Entity.Sistema.Enum;

namespace SalaoDoPantcho.Web.Controllers
{
    public class SistemaClienteController : Controller
    {
        #region Propriedades

        private IContractsAppServicesCliente appServicesCliente;
        private IContractsAppServicesEnderecosCliente appServicesEnderecoCliente;
        private IContractsAppServicesTelefonesCliente appServicesTelefoneCliente;

        #endregion

        #region Construtor

        public SistemaClienteController(IContractsAppServicesCliente appServicesCliente, IContractsAppServicesEnderecosCliente appServicesEnderecoCliente, IContractsAppServicesTelefonesCliente appServicesTelefoneCliente)
        {
            this.appServicesCliente = appServicesCliente;
            this.appServicesEnderecoCliente = appServicesEnderecoCliente;
            this.appServicesTelefoneCliente = appServicesTelefoneCliente;
        }

        #endregion

        #region Páginas

        // GET: SistemaCliente

        [OutputCache(Duration = 43200)]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cadastro()
        {
            return View();
        }

        #endregion

        #region Métodos

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CadastrarCliente(ViewModelClientesInserir modelInserirCliente)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Clientes Cliente = appServicesCliente.AppServicesPesquisarClientePorLoginEmail(modelInserirCliente.Login, modelInserirCliente.Email);
                    if (Cliente != null)
                    {
                        TempData["MensagemErro"] = "Login " + modelInserirCliente.Login + " e/ou Email " + modelInserirCliente.Email + " já cadastrado(s). Tente outro.";
                        return View("Cadastro");
                    }
                    else
                    {
                        Clientes cliente = new Clientes();
                        TelefonesCliente telefone = new TelefonesCliente();
                        cliente.EnderecosCliente = new EnderecosCliente();
                        cliente.TelefonesCliente = new List<TelefonesCliente>();
                        //cliente.EnderecosCliente = Mapper.Map<ViewModelClientesInserir, EnderecosCliente>(modelInserirCliente);

                        cliente.Apelido = modelInserirCliente.Apelido;
                        cliente.DataAlteracao = DateTime.Now.Date;
                        cliente.DataCadastro = DateTime.Now.Date;
                        cliente.Email = modelInserirCliente.Email;
                        cliente.GeneroSexo = modelInserirCliente.Genero;
                        cliente.Login = modelInserirCliente.Login;
                        cliente.Nome = modelInserirCliente.Nome;
                        cliente.Perfil = Perfil.Cliente;
                        cliente.StatusPessoa = StatusPessoa.Ativo;
                        cliente.Senha = CriptographyPassword.CriptografarSenha(modelInserirCliente.Senha);

                        cliente.EnderecosCliente.Bairro = modelInserirCliente.Bairro;
                        cliente.EnderecosCliente.CEP = modelInserirCliente.Cep;
                        cliente.EnderecosCliente.Complemento = modelInserirCliente.Complemento;
                        cliente.EnderecosCliente.DataAlteracao = DateTime.Now.Date;
                        cliente.EnderecosCliente.DataCadastro = DateTime.Now.Date;
                        cliente.EnderecosCliente.Descricao = modelInserirCliente.Descricao;
                        cliente.EnderecosCliente.Numero = modelInserirCliente.NumeroEnd;
                        cliente.EnderecosCliente.TipoEndereco = modelInserirCliente.TipoEndereco;

                        telefone.DataAlteracao = DateTime.Now.Date;
                        telefone.DataCadastro = DateTime.Now.Date;
                        telefone.DDD = modelInserirCliente.DDD;
                        telefone.Numero = modelInserirCliente.NumeroTel;
                        telefone.TipoTelefone = modelInserirCliente.TipoTelefone;

                        cliente.TelefonesCliente.Add(telefone);
                        cliente = ConvertionStrings.ConverterStringsClienteToLower(cliente);
                        if(appServicesCliente.AppServicesPesquisarClientePorLogin(cliente.Login) != null)
                        {
                            TempData["MensagemErro"] = "Já existe um cliente com o login " + cliente.Login + ". Tente outro login.";
                        }
                        else
                        {
                            appServicesCliente.AppServicesInserir(cliente);
                            TempData["MensagemSucesso"] = "Seu cadastro foi realizado com sucesso.";
                            ModelState.Clear();
                        }
                        return View("Cadastro");
                    }
                }
                catch(Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            return View("Cadastro");
        }

        //__________

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RealizarLoginCliente(ViewModelClientesLoginSenha modelClientesRealizarLoginCliente)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    Clientes cliente = appServicesCliente.AppServicesPesquisarClientePorLoginSenha(modelClientesRealizarLoginCliente.Login, CriptographyPassword.CriptografarSenha(modelClientesRealizarLoginCliente.Senha));
                    if(cliente == null)
                    {
                        Clientes clienteSenhaAux = appServicesCliente.AppServicesPesquisarClientePorLoginSenha(modelClientesRealizarLoginCliente.Login, modelClientesRealizarLoginCliente.Senha);
                        if(clienteSenhaAux != null)
                        {
                            FormsAuthentication.SetAuthCookie(clienteSenhaAux.Login, false);
                            Session.Add("cliente", clienteSenhaAux);
                            return RedirectToAction("Index", "SistemaClientes", new { area = "Cliente" });
                        }
                        else
                        {
                            TempData["MensagemErro"] = "Cliente " + modelClientesRealizarLoginCliente.Login + " não foi encontrado.";
                            return View("Index");
                        }
                    }
                    else
                    {
                        FormsAuthentication.SetAuthCookie(cliente.Login, false);
                        Session.Add("cliente", cliente);
                        return RedirectToAction("Index", "SistemaClientes", new { area = "Cliente" });
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            return View("Index");
        }

        //__________

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RecuperarLoginSenhaCliente(ViewModelClientesLoginSenha modelClientesRecuperarLoginSenha)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    Clientes cliente = appServicesCliente.AppServicesPesquisarClientePorNomeApelidoEmail(modelClientesRecuperarLoginSenha.Nomeapelido, modelClientesRecuperarLoginSenha.Email);
                    if(cliente != null)
                    {
                        appServicesCliente.AppServicesResetarSenhaCliente(cliente.IdCliente, cliente.Login);
                        TempData["MensagemSucesso"] = "Login e/ou Senha recuperado(s) com sucesso. Seu Login é: " + cliente.Login + " e sua Senha é: " + cliente.Login + ". Obs: essa é uma senha temporária e para sua segurança é necessário que você cadastre uma Nova Senha no sistema. Acesse sua Área Restrita de Cliente com seu Login e sua Senha, acione a funcionalidade Trocar Senha, siga os passos necessários e troque sua senha.";
                        return View("Index");
                    }
                    else
                    {
                        TempData["MensagemErro"] = "Cliente " + modelClientesRecuperarLoginSenha.Nomeapelido + " não foi encontrado.";
                        return View("Index");
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            return View();
        }

        #endregion
    }
}