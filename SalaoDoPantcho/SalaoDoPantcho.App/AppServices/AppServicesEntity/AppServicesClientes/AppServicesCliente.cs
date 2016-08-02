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
            this.appServicesCliente.ApagarClientePorEmailLoginSenhaService(email, login, senha);
        }

        public void AppServicesLoginSistema(string login, string senha)
        {
            this.appServicesCliente.LoginSistemaService(login, senha);
        }

        public void AppServicesLogoutSistema()
        {
            this.appServicesCliente.LogoutSistemaService();
        }

        public void AppTrocarSenha(string senhaAtual, string novaSenha)
        {
            this.appServicesCliente.TrocarSenhaService(senhaAtual, novaSenha);
        }

        public bool AppVerificarSenhaTemporaria(string login, string senha)
        {
            return this.appServicesCliente.VerificarSenhaTemporariaService(login, senha);
        }

        public void AppAtivarCliente(string login, string senha, StatusPessoa statusPessoa)
        {
            this.appServicesCliente.AtivarClienteService(login, senha, statusPessoa);
        }

        public void AppDesativarCliente(string login, string senha, StatusPessoa statusPessoa)
        {
            this.appServicesCliente.DesativarClienteService(login, senha, statusPessoa);
        }

        public void AppServicesResetarSenhaCliente(int id, string login)
        {
            this.appServicesCliente.ResetarSenhaClienteService(id, login);
        }

        public Clientes AppServicesPesquisarClientePorNomeApelidoEmail(string nomApelido, string email)
        {
            return this.appServicesCliente.PesquisarClientePorNomeApelidoEmailService(nomApelido, email);
        }

        public Clientes AppServicesPesquisarClientePorLoginEmail(string login, string email)
        {
            return this.appServicesCliente.PesquisarClientePorLoginEmailService(login, email);
        }

        public Clientes AppServicesPesquisarClientePorLoginSenha(string login, string senha)
        {
            return this.appServicesCliente.PesquisarClientePorLoginSenhaService(login, senha);
        }

        public Clientes AppServicesPesquisarClientePorLogin(string login)
        {
            return this.appServicesCliente.PesquisarClientePorLoginService(login);
        }

        #endregion
    }
}