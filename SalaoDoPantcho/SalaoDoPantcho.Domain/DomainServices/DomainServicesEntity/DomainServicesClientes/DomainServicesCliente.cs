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
            try
            {
                servicoCliente.ApagarClientePorEmailLoginSenhaPersistence(email, login, senha);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void LoginSistemaService(string login, string senha)
        {
            try
            {
                servicoCliente.LoginSistemaPersistence(login, senha);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void LogoutSistemaService()
        {
            try
            {
                servicoCliente.LogoutSistemaPersistence();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void TrocarSenhaService(string senhaAtual, string novaSenha)
        {
            try
            {
                this.servicoCliente.TrocarSenhaPersistence(senhaAtual, novaSenha);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool VerificarSenhaTemporariaService(string login, string senha)
        {
            try
            {
                return servicoCliente.VerificarSenhaTemporariaPersistence(login, senha);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void ResetarSenhaClienteService(Int32 id, string login)
        {
            try
            {
                servicoCliente.ResetarSenhaClientePersistence(id, login);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AtivarClienteService(string login, string senha, StatusPessoa StatusPessoa)
        {
            try
            {
                servicoCliente.AtivarClientePersistence(login, senha, StatusPessoa);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DesativarClienteService(string login, string senha, StatusPessoa statusPessoa)
        {
            try
            {
                servicoCliente.DesativarClientePersistence(login, senha, statusPessoa);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Clientes PesquisarClientePorNomeApelidoEmailService(string nomeApelido, string email)
        {
            try
            {
                return servicoCliente.PesquisarClientePorNomeApelidoEmailPersistence(nomeApelido, email);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Clientes PesquisarClientePorLoginEmailService(string login, string email)
        {
            try
            {
                return servicoCliente.PesquisarClientePorLoginEmailPersistence(login, email);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Clientes PesquisarClientePorLoginSenhaService(string login, string senha)
        {
            try
            {
                return servicoCliente.PesquisarClientePorLoginSenhaPersistence(login, senha);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Clientes PesquisarClientePorLoginService(string login)
        {
            try
            {
                return servicoCliente.PesquisarClientePorLoginPersistence(login);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion
    }
}