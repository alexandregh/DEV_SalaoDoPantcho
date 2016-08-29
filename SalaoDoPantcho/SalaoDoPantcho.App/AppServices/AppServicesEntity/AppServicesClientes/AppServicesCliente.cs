using System;
using SalaoDoPantcho.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesClientes;
using SalaoDoPantcho.App.IContractsAppServices.IContractsAppServicesEntity.IContractsAppServicesClientes;
using SalaoDoPantcho.App.AppServices.AppServicesBases;
using SalaoDoPantcho.Entity.Sistema.Entity;
using SalaoDoPantcho.Entity.Sistema.Enum;

namespace SalaoDoPantcho.App.AppServices.AppServicesEntity.AppServicesClientes
{
    public class AppServicesCliente : AppServicesBase<Clientes, Int32>, IContractsAppServicesCliente
    {
        #region Atributo

        private IContractsDomainServicesCliente appServicesCliente;

        #endregion

        #region Construtor

        public AppServicesCliente(IContractsDomainServicesCliente appServicesCliente)
            : base(appServicesCliente)
        {
            this.appServicesCliente = appServicesCliente;
        }

        #endregion

        #region Implementação Métodos Aplicação

        public void AppServicesApagarClientePorEmailLoginSenha(string email, string login, string senha)
        {
            appServicesCliente.ApagarClientePorEmailLoginSenhaService(email, login, senha);
        }

        public void AppServicesLoginSistema(string login, string senha)
        {
            appServicesCliente.LoginSistemaService(login, senha);
        }

        public void AppServicesLogoutSistema()
        {
            appServicesCliente.LogoutSistemaService();
        }

        public void AppTrocarSenha(string senhaAtual, string novaSenha)
        {
            appServicesCliente.TrocarSenhaService(senhaAtual, novaSenha);
        }

        public bool AppVerificarSenhaTemporaria(string login, string senha)
        {
            return appServicesCliente.VerificarSenhaTemporariaService(login, senha);
        }

        public void AppAtivarCliente(string login, string senha, StatusPessoa statusPessoa)
        {
            appServicesCliente.AtivarClienteService(login, senha, statusPessoa);
        }

        public void AppDesativarCliente(string login, string senha, StatusPessoa statusPessoa)
        {
            appServicesCliente.DesativarClienteService(login, senha, statusPessoa);
        }

        public void AppServicesResetarSenhaCliente(int id, string login)
        {
            appServicesCliente.ResetarSenhaClienteService(id, login);
        }

        public Clientes AppServicesPesquisarClientePorNomeApelidoEmail(string nomApelido, string email)
        {
            return appServicesCliente.PesquisarClientePorNomeApelidoEmailService(nomApelido, email);
        }

        public Clientes AppServicesPesquisarClientePorLoginEmail(string login, string email)
        {
            return appServicesCliente.PesquisarClientePorLoginEmailService(login, email);
        }

        public Clientes AppServicesPesquisarClientePorLoginSenha(string login, string senha)
        {
            return appServicesCliente.PesquisarClientePorLoginSenhaService(login, senha);
        }

        public Clientes AppServicesPesquisarClientePorLogin(string login)
        {
            return appServicesCliente.PesquisarClientePorLoginService(login);
        }

        #endregion
    }
}