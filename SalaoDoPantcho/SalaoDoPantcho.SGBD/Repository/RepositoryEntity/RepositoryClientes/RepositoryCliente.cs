using System;
using System.Linq;
using SalaoDoPantcho.Domain.IContracts.IContractsInfraEstructure.IContractsSGBD.IContractsSGBDEntity.IContractsSGBDClientes;
using SalaoDoPantcho.SGBD.Repository.RepositoryBases;
using SalaoDoPantcho.Entity.Sistema.Entity;
using SalaoDoPantcho.Entity.Sistema.Enum;

namespace SalaoDoPantcho.SGBD.Repository.RepositoryEntity.RepositoryClientes
{
    public class RepositoryCliente : RepositoryBase<Clientes, Int32>, IContractsSGBDCliente
    {
        #region Implementação Métodos Persistentes

        public void ApagarClientePorEmailLoginSenhaPersistence(string email, string login, string senha)
        {
            try
            {
                Clientes cliente = dataContext.Clientes.AsNoTracking()
                                   .Where(cli => cli.Email == email && cli.Login == login && cli.Senha == senha)
                                   .FirstOrDefault();
                if (cliente != null)
                {
                    ExcluirPersistence(cliente);
                }
            }
            catch (ArgumentNullException ex)
            {
                throw new ArgumentNullException("Ocorreu o erro: " + ex.Message + ". Aguarde alguns instantes e tente novamente.");
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu o seguinte erro desconhecido: " + ex.Message + ". Aguarde alguns instantes e tente novamente ou contate o Suporte do Sistema.");
            }
        }

        public void LoginSistemaPersistence(string login, string senha)
        {
            throw new NotImplementedException();
        }

        public void LogoutSistemaPersistence()
        {
            throw new NotImplementedException();
        }

        public void TrocarSenhaPersistence(string senhaAtual, string novaSenha)
        {
            try
            {
                Clientes cliente = dataContext.Clientes.AsNoTracking()
                                   .Where(cli => cli.Senha == senhaAtual)
                                   .FirstOrDefault();
                if (cliente != null)
                {
                    cliente.Senha = novaSenha;
                    AtualizarPersistence(cliente);
                }
            }
            catch (ArgumentNullException ex)
            {
                throw new ArgumentNullException("Ocorreu o erro: " + ex.Message + ". Aguarde alguns instantes e tente novamente.");
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu o seguinte erro desconhecido: " + ex.Message + ". Aguarde alguns instantes e tente novamente ou contate o Suporte do Sistema.");
            }
        }

        public void ResetarSenhaClientePersistence(Int32 id, string login)
        {
            try
            {
                Clientes cliente = dataContext.Clientes.AsNoTracking()
                                   .Where(cli => cli.IdCliente == id)
                                   .FirstOrDefault();
                if(cliente != null)
                {
                    cliente.Senha = login;
                    AtualizarPersistence(cliente);
                }
            }
            catch (ArgumentNullException ex)
            {
                throw new ArgumentNullException("Ocorreu o erro: " + ex.Message + ". Aguarde alguns instantes e tente novamente.");
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu o seguinte erro desconhecido: " + ex.Message + ". Aguarde alguns instantes e tente novamente ou contate o Suporte do Sistema.");
            }
        }

        public bool VerificarSenhaTemporariaPersistence(string login, string senha)
        {
            try
            {
                Clientes cliente = dataContext.Clientes.AsNoTracking()
                                   .Where(cli => cli.Login == login && cli.Senha == senha)
                                   .FirstOrDefault();                
                if (cliente.Login == cliente.Senha)
                {
                    return true; // se a senha ainda estiver como temporária...
                }
                else
                {
                    return false;
                }                
            }
            catch (ArgumentNullException ex)
            {
                throw new ArgumentNullException("Ocorreu o erro: " + ex.Message + ". Aguarde alguns instantes e tente novamente.");
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu o seguinte erro desconhecido: " + ex.Message + ". Aguarde alguns instantes e tente novamente ou contate o Suporte do Sistema.");
            }
        }

        public void AtivarClientePersistence(string login, string senha, StatusPessoa statusPessoa)
        {
            try
            {
                Clientes cliente = dataContext.Clientes.AsNoTracking()
                                   .Where(cli => cli.Login == login && cli.Senha == senha)
                                   .FirstOrDefault();
                cliente.StatusPessoa = StatusPessoa.Ativo;
                AtualizarPersistence(cliente);
            }
            catch (ArgumentNullException ex)
            {
                throw new ArgumentNullException("Ocorreu o erro: " + ex.Message + ". Aguarde alguns instantes e tente novamente.");
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu o seguinte erro desconhecido: " + ex.Message + ". Aguarde alguns instantes e tente novamente ou contate o Suporte do Sistema.");
            }
        }

        public void DesativarClientePersistence(string login, string senha, StatusPessoa statusPessoa)
        {
            try
            {
                Clientes cliente = dataContext.Clientes.Where(cli => cli.Login == login && cli.Senha == senha)
                                   .FirstOrDefault();
                cliente.StatusPessoa = StatusPessoa.Inativo;
                AtualizarPersistence(cliente);
            }
            catch (ArgumentNullException ex)
            {
                throw new ArgumentNullException("Ocorreu o erro: " + ex.Message + ". Aguarde alguns instantes e tente novamente.");
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu o seguinte erro desconhecido: " + ex.Message + ". Aguarde alguns instantes e tente novamente ou contate o Suporte do Sistema.");
            }
        }

        public Clientes PesquisarClientePorNomeApelidoEmailPersistence(string nomeApelido, string email)
        {
            try
            {
                Clientes clientePorNome = dataContext.Clientes.AsNoTracking()
                                          .Where(cli => cli.Nome == nomeApelido && cli.Email == email)
                                          .FirstOrDefault();
                if(clientePorNome != null)
                {
                    return clientePorNome;
                }
                else
                {
                    Clientes clientePorApelido = dataContext.Clientes.AsNoTracking()
                                                 .Where(cli => cli.Apelido == nomeApelido && cli.Email == email)
                                                 .FirstOrDefault();
                    return clientePorApelido;
                }
            }
            catch (ArgumentNullException ex)
            {
                throw new ArgumentNullException("Ocorreu o erro: " + ex.Message + ". Aguarde alguns instantes e tente novamente.");
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu o seguinte erro desconhecido: " + ex.Message + ". Aguarde alguns instantes e tente novamente ou contate o Suporte do Sistema.");
            }
        }

        public Clientes PesquisarClientePorLoginEmailPersistence(string login, string email)
        {
            try
            {
                Clientes clientePorLoginEmail = dataContext.Clientes.AsNoTracking()
                                                .Where(cliente => cliente.Login == login || cliente.Email == email)
                                                .FirstOrDefault();
                if(clientePorLoginEmail != null)
                {
                    return clientePorLoginEmail;
                }
                else
                {
                    return clientePorLoginEmail;
                }
            }
            catch (ArgumentNullException ex)
            {
                throw new ArgumentNullException("Ocorreu o erro: " + ex.Message + ". Aguarde alguns instantes e tente novamente.");
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu o seguinte erro desconhecido: " + ex.Message + ". Aguarde alguns instantes e tente novamente ou contate o Suporte do Sistema.");
            }
        }

        public Clientes PesquisarClientePorLoginSenhaPersistence(string login, string senha)
        {
            try
            {
                Clientes clientePorLoginSenha = dataContext.Clientes.AsNoTracking()
                                                .Where(cliente => cliente.Login == login && cliente.Senha == senha)
                                                .FirstOrDefault();
                return clientePorLoginSenha;
            }
            catch (ArgumentNullException ex)
            {
                throw new ArgumentNullException("Ocorreu o erro: " + ex.Message + ". Aguarde alguns instantes e tente novamente.");
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu o seguinte erro desconhecido: " + ex.Message + ". Aguarde alguns instantes e tente novamente ou contate o Suporte do Sistema.");
            }
        }

        public Clientes PesquisarClientePorLoginPersistence(string login)
        {
            try
            {
                Clientes clientePorLogin = dataContext.Clientes.AsNoTracking()
                                           .Where(cliente => cliente.Login == login)
                                           .FirstOrDefault();
                if(clientePorLogin != null)
                {
                    return clientePorLogin;
                }
                else
                {
                    return clientePorLogin;
                }
            }
            catch (ArgumentNullException ex)
            {
                throw new ArgumentNullException("Ocorreu o erro: " + ex.Message + ". Aguarde alguns instantes e tente novamente.");
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu o seguinte erro desconhecido: " + ex.Message + ". Aguarde alguns instantes e tente novamente ou contate o Suporte do Sistema.");
            }
        }

        #endregion
    }
}