using System;
using SalaoDoPantcho.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesBases;
using SalaoDoPantcho.Entity.Sistema.Entity;
using SalaoDoPantcho.Entity.Sistema.Enum;

namespace SalaoDoPantcho.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesClientes
{
    public interface IContractsDomainServicesCliente : IContractsDomainServicesBase<Clientes, Int32>
    {
        // métodos específicos...
        #region Login

        void LoginSistemaService(string login, string senha);
        void LogoutSistemaService();

        #endregion

        #region Pesquisa Específica

        Clientes PesquisarClientePorNomeApelidoEmailService(string nomeApelido, string email);
        Clientes PesquisarClientePorLoginSenhaService(string login, string senha);
        Clientes PesquisarClientePorLoginEmailService(string login, string email);
        Clientes PesquisarClientePorLoginService(string login);

        #endregion

        #region Serviços Cliente

        bool VerificarSenhaTemporariaService(string login, string senha);
        void TrocarSenhaService(string senhaAtual, string novaSenha);
        void ResetarSenhaClienteService(Int32 id, string login);
        void ApagarClientePorEmailLoginSenhaService(string email, string login, string senha);
        void AtivarClienteService(string login, string senha, StatusPessoa StatusPessoa);
        void DesativarClienteService(string login, string senha, StatusPessoa StatusPessoa);

        #endregion
    }
}