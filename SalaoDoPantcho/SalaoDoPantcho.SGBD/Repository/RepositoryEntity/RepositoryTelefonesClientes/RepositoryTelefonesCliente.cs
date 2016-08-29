using System;
using System.Collections.Generic;
using System.Linq;
using SalaoDoPantcho.Domain.IContracts.IContractsInfraEstructure.IContractsSGBD.IContractsSGBDEntity.IContractsSGBDTelefonesClientes;
using SalaoDoPantcho.SGBD.Repository.RepositoryBases;
using SalaoDoPantcho.Entity.Sistema.Entity;
using SalaoDoPantcho.Entity.Sistema.Enum;

namespace SalaoDoPantcho.SGBD.Repository.RepositoryEntity.RepositoryTelefonesClientes
{
    public class RepositoryTelefoneCliente : RepositoryBase<TelefonesCliente, Int32>, IContractsSGBDTelefonesCliente
    {
        #region Implementação Métodos Persistentes

        public TelefonesCliente PesquisarTelefonePorDDDPersistence(byte ddd)
        {
            if (ddd != byte.MinValue)
            {
                try
                {
                    TelefonesCliente telefoneClientePorDDD = dataContext.TelefonesCliente.AsParallel()
                                                             .Where(telefone => telefone.DDD == ddd)
                                                             .FirstOrDefault();
                    if (telefoneClientePorDDD != null)
                    {
                        dataContext.Dispose();
                        return telefoneClientePorDDD;
                    }
                    else
                    {
                        dataContext.Dispose();
                        return null;
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
                return null;
            }
        }

        public TelefonesCliente PesquisarTelefonePorNumeroPersistence(int numero)
        {
            if (numero != 0)
            {
                try
                {
                    TelefonesCliente telefoneClientePorNumero = dataContext.TelefonesCliente.AsParallel()
                                                                .Where(telefone => telefone.Numero == numero)
                                                                .FirstOrDefault();
                    if (telefoneClientePorNumero != null)
                    {
                        dataContext.Dispose();
                        return telefoneClientePorNumero;
                    }
                    else
                    {
                        dataContext.Dispose();
                        return telefoneClientePorNumero;
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
                return null;
            }
        }

        public TelefonesCliente PesquisarTelefonePorTipoTelefonePersistence(TipoTelefones tipoTelefone)
        {
            if (tipoTelefone != 0)
            {
                try
                {
                    TelefonesCliente telefoneClientePorTipoTelefone = dataContext.TelefonesCliente.AsParallel()
                                                                     .Where(telefone => telefone.TipoTelefone == tipoTelefone)
                                                                     .FirstOrDefault();
                    if (telefoneClientePorTipoTelefone != null)
                    {
                        dataContext.Dispose();
                        return telefoneClientePorTipoTelefone;
                    }
                    else
                    {
                        dataContext.Dispose();
                        return null;
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
                return null;
            }
        }

        //___________________

        public ICollection<TelefonesCliente> PesquisarTelefonesPorDDDPersistence(byte ddd)
        {
            if (ddd != byte.MinValue)
            {
                try
                {
                    List<TelefonesCliente> telefoneClientePorDDD = dataContext.TelefonesCliente.AsParallel()
                                                                   .Where(telefone => telefone.DDD == ddd)
                                                                   .ToList();
                    if (telefoneClientePorDDD != null)
                    {
                        dataContext.Dispose();
                        return telefoneClientePorDDD;
                    }
                    else
                    {
                        dataContext.Dispose();
                        return null;
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
                return null;
            }
        }

        public ICollection<TelefonesCliente> PesquisarTelefonesPorNumeroPersistence(int numero)
        {
            if (numero != 0)
            {
                try
                {
                    List<TelefonesCliente> telefoneClientePorNumero = dataContext.TelefonesCliente.AsParallel()
                                                                      .Where(telefone => telefone.Numero == numero)
                                                                      .ToList();
                    if (telefoneClientePorNumero != null)
                    {
                        dataContext.Dispose();
                        return telefoneClientePorNumero;
                    }
                    else
                    {
                        dataContext.Dispose();
                        return null;
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
                return null;
            }
        }

        public ICollection<TelefonesCliente> PesquisarTelefonesPorTipoTelefonePersistence(TipoTelefones tipoTelefone)
        {
            if (tipoTelefone != 0)
            {
                try
                {
                    List<TelefonesCliente> telefoneClientePorTipo = dataContext.TelefonesCliente.AsParallel()
                                                                    .Where(telefone => telefone.TipoTelefone == tipoTelefone)
                                                                    .ToList();
                    if (telefoneClientePorTipo != null)
                    {
                        dataContext.Dispose();
                        return telefoneClientePorTipo;
                    }
                    else
                    {
                        dataContext.Dispose();
                        return null;
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
                return null;
            }
        }

        #endregion
    }
}