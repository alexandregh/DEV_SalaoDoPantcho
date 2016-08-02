using System;
using SalaoDoPantcho.App.IContractsAppServices.IContractsAppServicesBases;
using SalaoDoPantcho.Entity.Sistema.Entity;
using SalaoDoPantcho.Entity.Sistema.Enum;

namespace SalaoDoPantcho.App.IContractsAppServices.IContractsAppServicesEntity.IContractsAppServicesClientes
{
    public interface IContractsAppServicesCliente : IContractsAppServicesBase<Clientes, Int32>
    {
        // métodos específicos...
        #region Login

        void AppServicesLoginSistema(string login, string senha);
        void AppServicesLogoutSistema();

        #endregion

        #region Pesquisa Específica

        Clientes AppServicesPesquisarClientePorNomeApelidoEmail(string nomApelido, string email);
        Clientes AppServicesPesquisarClientePorLoginSenha(string login, string senha);
        Clientes AppServicesPesquisarClientePorLoginEmail(string login, string email);
        Clientes AppServicesPesquisarClientePorLogin(string login);

        #endregion

        #region Serviços Cliente

        bool AppVerificarSenhaTemporaria(string login, string senha);
        void AppTrocarSenha(string senhaAtual, string novaSenha);
        void AppServicesResetarSenhaCliente(Int32 id, string login);
        void AppServicesApagarClientePorEmailLoginSenha(string email, string login, string senha);
        void AppAtivarCliente(string login, string senha, StatusPessoa statusPessoa);
        void AppDesativarCliente(string login, string senha, StatusPessoa statusPessoa);

        #endregion
    }
}