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
            if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(senha))
            {
                try
                {
                    Clientes cliente = dataContext.Clientes.AsParallel()
                                       .Where(cli => cli.Email == email && cli.Login == login && cli.Senha == senha)
                                       .FirstOrDefault();
                    if (cliente != null)
                    {
                        ExcluirPersistence(cliente);
                    }
                }
                catch (ArgumentNullException ex)
                {
                    throw new ArgumentNullException(nameof(ex.Message));
                }
                catch (Exception ex)
                {
                    throw new Exception(nameof(ex.Message));
                }
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
            if (!string.IsNullOrEmpty(senhaAtual) && !string.IsNullOrEmpty(novaSenha))
            {
                try
                {
                    Clientes cliente = dataContext.Clientes.AsParallel()
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
                    throw new ArgumentNullException(nameof(ex.Message));
                }
                catch (Exception ex)
                {
                    throw new Exception(nameof(ex.Message));
                }
            }
        }

        public void ResetarSenhaClientePersistence(Int32 id, string login)
        {
            if (id != 0 && !string.IsNullOrEmpty(login))
            {
                try
                {
                    Clientes cliente = dataContext.Clientes.AsParallel()
                                       .Where(cli => cli.IdCliente == id && cli.Login == login)
                                       .FirstOrDefault();
                    if (cliente != null)
                    {
                        cliente.Senha = login;
                        AtualizarPersistence(cliente);
                    }
                }
                catch (ArgumentNullException ex)
                {
                    throw new ArgumentNullException(nameof(ex.Message));
                }
                catch (Exception ex)
                {
                    throw new Exception(nameof(ex.Message));
                }
            }
        }

        public bool VerificarSenhaTemporariaPersistence(string login, string senha)
        {
            if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(senha))
            {
                try
                {
                    Clientes cliente = dataContext.Clientes.AsParallel()
                                       .Where(cli => cli.Login == login && cli.Senha == senha)
                                       .FirstOrDefault();
                    if (cliente.Login == cliente.Senha)
                    {
                        dataContext.Dispose();
                        return true; // se a senha ainda estiver como temporária...
                    }
                    else
                    {
                        dataContext.Dispose();
                        return false;
                    }
                }
                catch (ArgumentNullException ex)
                {
                    throw new ArgumentNullException(nameof(ex.Message));
                }
                catch (Exception ex)
                {
                    throw new Exception(nameof(ex.Message));
                }
            }
            else
            {
                dataContext.Dispose();
                return false;
            }
        }

        public void AtivarClientePersistence(string login, string senha, StatusPessoa statusPessoa)
        {
            if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(senha) && statusPessoa != 0)
            {
                try
                {
                    Clientes cliente = dataContext.Clientes.AsParallel()
                                       .Where(cli => cli.Login == login && cli.Senha == senha)
                                       .FirstOrDefault();
                    cliente.StatusPessoa = StatusPessoa.Ativo;
                    AtualizarPersistence(cliente);
                }
                catch (ArgumentNullException ex)
                {
                    throw new ArgumentNullException(nameof(ex.Message));
                }
                catch (Exception ex)
                {
                    throw new Exception(nameof(ex.Message));
                }
            }
        }

        public void DesativarClientePersistence(string login, string senha, StatusPessoa statusPessoa)
        {
            if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(senha) && statusPessoa != 0)
            {
                try
                {
                    Clientes cliente = dataContext.Clientes.AsParallel()
                                       .Where(cli => cli.Login == login && cli.Senha == senha)
                                       .FirstOrDefault();
                    cliente.StatusPessoa = StatusPessoa.Inativo;
                    AtualizarPersistence(cliente);
                }
                catch (ArgumentNullException ex)
                {
                    throw new ArgumentNullException(nameof(ex.Message));
                }
                catch (Exception ex)
                {
                    throw new Exception(nameof(ex.Message));
                }
            }
        }

        public Clientes PesquisarClientePorNomeApelidoEmailPersistence(string nomeApelido, string email)
        {
            if (!string.IsNullOrEmpty(nomeApelido) && !string.IsNullOrEmpty(email))
            {
                try
                {
                    Clientes clientePorNome = dataContext.Clientes.AsParallel()
                                              .Where(cli => cli.Nome == nomeApelido && cli.Email == email)
                                              .FirstOrDefault();
                    if (clientePorNome != null)
                    {
                        dataContext.Dispose();
                        return clientePorNome;
                    }
                    else
                    {
                        Clientes clientePorApelido = dataContext.Clientes.AsParallel()
                                                     .Where(cli => cli.Apelido == nomeApelido && cli.Email == email)
                                                     .FirstOrDefault();
                        dataContext.Dispose();
                        return clientePorApelido;
                    }
                }
                catch (ArgumentNullException ex)
                {
                    throw new ArgumentNullException(nameof(ex.Message));
                }
                catch (Exception ex)
                {
                    throw new Exception(nameof(ex.Message));
                }
            }
            else
            {
                dataContext.Dispose();
                return null;
            }
        }

        public Clientes PesquisarClientePorLoginEmailPersistence(string login, string email)
        {
            if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(email))
            {
                try
                {
                    Clientes clientePorLoginEmail = dataContext.Clientes.AsParallel()
                                                    .Where(cliente => cliente.Login == login || cliente.Email == email)
                                                    .FirstOrDefault();
                    if (clientePorLoginEmail != null)
                    {
                        dataContext.Dispose();
                        return clientePorLoginEmail;
                    }
                    else
                    {
                        dataContext.Dispose();
                        return clientePorLoginEmail;
                    }
                }
                catch (ArgumentNullException ex)
                {
                    throw new ArgumentNullException(nameof(ex.Message));
                }
                catch (Exception ex)
                {
                    throw new Exception(nameof(ex.Message));
                }
            }
            else
            {
                dataContext.Dispose();
                return null;
            }
        }

        public Clientes PesquisarClientePorLoginSenhaPersistence(string login, string senha)
        {
            if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(senha))
            {
                try
                {
                    Clientes clientePorLoginSenha = dataContext.Clientes.AsParallel()
                                                    .Where(cliente => cliente.Login == login && cliente.Senha == senha)
                                                    .FirstOrDefault();
                    if (clientePorLoginSenha != null)
                    {
                        dataContext.Dispose();
                        return clientePorLoginSenha;
                    }
                    else
                    {
                        dataContext.Dispose();
                        return clientePorLoginSenha;
                    }
                }
                catch (ArgumentNullException ex)
                {
                    throw new ArgumentNullException(nameof(ex.Message));
                }
                catch (Exception ex)
                {
                    throw new Exception(nameof(ex.Message));
                }
            }
            else
            {
                dataContext.Dispose();
                return null;
            }
        }

        public Clientes PesquisarClientePorLoginPersistence(string login)
        {
            if (!string.IsNullOrEmpty(login))
            {
                try
                {
                    Clientes clientePorLogin = dataContext.Clientes.AsParallel()
                                               .Where(cliente => cliente.Login == login)
                                               .FirstOrDefault();
                    if (clientePorLogin != null)
                    {
                        dataContext.Dispose();
                        return clientePorLogin;
                    }
                    else
                    {
                        dataContext.Dispose();
                        return clientePorLogin;
                    }
                }
                catch (ArgumentNullException ex)
                {
                    throw new ArgumentNullException(nameof(ex.Message));
                }
                catch (Exception ex)
                {
                    throw new Exception(nameof(ex.Message));
                }
            }
            else
            {
                dataContext.Dispose();
                return null;
            }
        }

        #endregion
    }
}