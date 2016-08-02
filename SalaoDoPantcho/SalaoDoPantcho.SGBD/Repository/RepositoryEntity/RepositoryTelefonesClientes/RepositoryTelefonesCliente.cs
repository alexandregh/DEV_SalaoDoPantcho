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
            try
            {
                TelefonesCliente telefoneClientePorDDD = dataContext.TelefonesCliente.AsNoTracking()
                                                         .Where(telefone => telefone.DDD == ddd)
                                                         .FirstOrDefault();
                if (telefoneClientePorDDD != null)
                {
                    return telefoneClientePorDDD;
                }
                else
                {
                    return null;
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

        public TelefonesCliente PesquisarTelefonePorNumeroPersistence(int numero)
        {
            try
            {
                TelefonesCliente telefoneClientePorNumero = dataContext.TelefonesCliente.AsNoTracking()
                                                            .Where(telefone => telefone.Numero == numero)
                                                            .FirstOrDefault();
                if (telefoneClientePorNumero != null)
                {
                    return telefoneClientePorNumero;
                }
                else
                {
                    return telefoneClientePorNumero;
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

        public TelefonesCliente PesquisarTelefonePorTipoTelefonePersistence(TipoTelefones tipoTelefone)
        {
            try
            {
                TelefonesCliente telefoneClientePorTipoTelefone = dataContext.TelefonesCliente.AsNoTracking()
                                                                 .Where(telefone => telefone.TipoTelefone == tipoTelefone)
                                                                 .FirstOrDefault();
                if (telefoneClientePorTipoTelefone != null)
                {
                    return telefoneClientePorTipoTelefone;
                }
                else
                {
                    return telefoneClientePorTipoTelefone;
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


        public ICollection<TelefonesCliente> PesquisarTelefonesPorDDDPersistence(byte ddd)
        {
            try
            {
                List<TelefonesCliente> telefoneClientePorDDD = dataContext.TelefonesCliente.AsNoTracking()
                                                               .Where(telefone => telefone.DDD == ddd)
                                                               .ToList();
                if (telefoneClientePorDDD != null)
                {
                    return telefoneClientePorDDD;
                }
                else
                {
                    return telefoneClientePorDDD;
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

        public ICollection<TelefonesCliente> PesquisarTelefonesPorNumeroPersistence(int numero)
        {
            try
            {
                List<TelefonesCliente> telefoneClientePorNumero = dataContext.TelefonesCliente.AsNoTracking()
                                                                  .Where(telefone => telefone.Numero == numero)
                                                                  .ToList();
                if (telefoneClientePorNumero != null)
                {
                    return telefoneClientePorNumero;
                }
                else
                {
                    return telefoneClientePorNumero;
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

        public ICollection<TelefonesCliente> PesquisarTelefonesPorTipoTelefonePersistence(TipoTelefones tipoTelefone)
        {
            try
            {
                List<TelefonesCliente> telefoneClientePorTipo = dataContext.TelefonesCliente.AsNoTracking()
                                                                .Where(telefone => telefone.TipoTelefone == tipoTelefone)
                                                                .ToList();
                if (telefoneClientePorTipo != null)
                {
                    return telefoneClientePorTipo;
                }
                else
                {
                    return telefoneClientePorTipo;
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