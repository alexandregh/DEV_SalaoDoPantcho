using System;
using SalaoDoPantcho.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesClientes;
using SalaoDoPantcho.Domain.IContracts.IContractsInfraEstructure.IContractsSGBD.IContractsSGBDEntity.IContractsSGBDClientes;
using SalaoDoPantcho.Domain.DomainServices.DomainServicesBases;
using SalaoDoPantcho.Entity.Sistema.Entity;
using SalaoDoPantcho.Entity.Sistema.Enum;

namespace SalaoDoPantcho.Domain.DomainServices.DomainServicesEntity.DomainServicesClientes
{
    public class DomainServicesCliente : DomainServicesBase<Clientes, int>, IContractsDomainServicesCliente
    {
        #region Atributo

        private IContractsSGBDCliente servicoCliente;

        #endregion

        #region Construtor

        public DomainServicesCliente(IContractsSGBDCliente servicoCliente)
            : base(servicoCliente)
        {
            this.servicoCliente = servicoCliente;
        }

        #endregion

        #region Implementação Métodos Serviços

        public void ApagarClientePorEmailLoginSenhaService(string email, string login, string senha)
        {
            servicoCliente.ApagarClientePorEmailLoginSenhaPersistence(email, login, senha);
        }

        public void LoginSistemaService(string login, string senha)
        {
            servicoCliente.LoginSistemaPersistence(login, senha);
        }

        public void LogoutSistemaService()
        {
            servicoCliente.LogoutSistemaPersistence();
        }

        public void TrocarSenhaService(string senhaAtual, string novaSenha)
        {
            this.servicoCliente.TrocarSenhaPersistence(senhaAtual, novaSenha);
        }

        public bool VerificarSenhaTemporariaService(string login, string senha)
        {
            return servicoCliente.VerificarSenhaTemporariaPersistence(login, senha);
        }

        public void ResetarSenhaClienteService(Int32 id, string login)
        {
            servicoCliente.ResetarSenhaClientePersistence(id, login);
        }

        public void AtivarClienteService(string login, string senha, StatusPessoa StatusPessoa)
        {
            servicoCliente.AtivarClientePersistence(login, senha, StatusPessoa);
        }

        public void DesativarClienteService(string login, string senha, StatusPessoa statusPessoa)
        {
            servicoCliente.DesativarClientePersistence(login, senha, statusPessoa);
        }

        public Clientes PesquisarClientePorNomeApelidoEmailService(string nomeApelido, string email)
        {
            
            return servicoCliente.PesquisarClientePorNomeApelidoEmailPersistence(nomeApelido, email);
        }

        public Clientes PesquisarClientePorLoginEmailService(string login, string email)
        {
            return servicoCliente.PesquisarClientePorLoginEmailPersistence(login, email);
        }

        public Clientes PesquisarClientePorLoginSenhaService(string login, string senha)
        {
            return servicoCliente.PesquisarClientePorLoginSenhaPersistence(login, senha);
        }

        public Clientes PesquisarClientePorLoginService(string login)
        {
            return servicoCliente.PesquisarClientePorLoginPersistence(login);
        }

        #endregion
    }
}