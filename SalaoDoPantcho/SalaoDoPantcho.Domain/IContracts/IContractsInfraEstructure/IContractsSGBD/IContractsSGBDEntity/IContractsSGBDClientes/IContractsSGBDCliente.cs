using System;
using SalaoDoPantcho.Domain.IContracts.IContractsInfraEstructure.IContractsSGBD.IContractsSGBDBases;
using SalaoDoPantcho.Entity.Sistema.Entity;
using SalaoDoPantcho.Entity.Sistema.Enum;

namespace SalaoDoPantcho.Domain.IContracts.IContractsInfraEstructure.IContractsSGBD.IContractsSGBDEntity.IContractsSGBDClientes
{
    public interface IContractsSGBDCliente : IContractsSGBDBase<Clientes, Int32>
    {
        // métodos específicos...
        #region Login

        void LoginSistemaPersistence(string login, string senha);
        void LogoutSistemaPersistence();

        #endregion

        #region Pesquisa Específica

        Clientes PesquisarClientePorNomeApelidoEmailPersistence(string nomeApelido, string email);
        Clientes PesquisarClientePorLoginSenhaPersistence(string login, string senha);
        Clientes PesquisarClientePorLoginEmailPersistence(string login, string email);
        Clientes PesquisarClientePorLoginPersistence(string login);

        #endregion

        #region Serviços Cliente

        bool VerificarSenhaTemporariaPersistence(string login, string senha);
        void TrocarSenhaPersistence(string senhaAtual, string novaSenha);
        void ResetarSenhaClientePersistence(Int32 id, string login);
        void ApagarClientePorEmailLoginSenhaPersistence(string email, string login, string senha);
        void AtivarClientePersistence(string login, string senha, StatusPessoa statusPessoa);
        void DesativarClientePersistence(string login, string senha, StatusPessoa statusPessoa);

        #endregion
    }
}