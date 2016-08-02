using System;
using System.Collections.Generic;
using System.Linq;
using SalaoDoPantcho.Domain.IContracts.IContractsInfraEstructure.IContractsSGBD.IContractsSGBDEntity.IContractsSGBDEnderecosClientes;
using SalaoDoPantcho.SGBD.Repository.RepositoryBases;
using SalaoDoPantcho.Entity.Sistema.Entity;
using SalaoDoPantcho.Entity.Sistema.Enum;

namespace SalaoDoPantcho.SGBD.Repository.RepositoryEntity.RepositoryEnderecosClientes
{
    public class RepositoryEnderecosCliente : RepositoryBase<EnderecosCliente, Int32>, IContractsSGBDEnderecosCliente
    {
        #region Implementação Métodos Persistentes

        public EnderecosCliente PesquisarEnderecoPorTipoEnderecoPersistence(TipoEnderecos tipoEndereco)
        {
            try
            {
                EnderecosCliente enderecoClientePorTipoEnderecos = dataContext.EnderecosCliente.AsNoTracking()
                                                            .Where(endereco => endereco.TipoEndereco == tipoEndereco)
                                                            .FirstOrDefault();
                if (enderecoClientePorTipoEnderecos != null)
                {
                    return enderecoClientePorTipoEnderecos;
                }
                else
                {
                    return enderecoClientePorTipoEnderecos;
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

        public EnderecosCliente PesquisarEnderecoPorBairroPersistence(string bairro)
        {
            try
            {
                EnderecosCliente enderecoClientePorBairro = dataContext.EnderecosCliente.AsNoTracking()
                                                            .Where(endereco => endereco.Bairro == bairro)
                                                            .FirstOrDefault();
                if (enderecoClientePorBairro != null)
                {
                    return enderecoClientePorBairro;
                }
                else
                {
                    return enderecoClientePorBairro;
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

        public EnderecosCliente PesquisarEnderecoPorCepPersistence(string cep)
        {
            try
            {
                EnderecosCliente enderecoClientePorCep = dataContext.EnderecosCliente
                                                         .Where(endereco => endereco.CEP == cep)
                                                         .FirstOrDefault();
                return enderecoClientePorCep;
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

        //_________

        public ICollection<EnderecosCliente> PesquisarEnderecosPorBairroPersistence(string bairro)
        {
            try
            {
                List<EnderecosCliente> enderecoClientePorBairro = dataContext.EnderecosCliente.AsNoTracking().
                                                                  Where(endereco => endereco.Bairro == bairro).ToList();
                if (enderecoClientePorBairro != null)
                {
                    return enderecoClientePorBairro;
                }
                else
                {
                    return enderecoClientePorBairro;
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

        public ICollection<EnderecosCliente> PesquisarEnderecosPorCepPersistence(string cep)
        {
            try
            {
                List<EnderecosCliente> enderecoClientePorCep = dataContext.EnderecosCliente.AsNoTracking().
                                                               Where(endereco => endereco.CEP == cep).ToList();
                if (enderecoClientePorCep != null)
                {
                    return enderecoClientePorCep;
                }
                else
                {
                    return enderecoClientePorCep;
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

        public ICollection<EnderecosCliente> PesquisarEnderecosPorTipoEnderecosPersistence(TipoEnderecos tipoEndereco)
        {
            try
            {
                List<EnderecosCliente> enderecoClientePorTipoEnderecos = dataContext.EnderecosCliente.AsNoTracking().
                                                                         Where(endereco => endereco.TipoEndereco == tipoEndereco)
                                                                         .ToList();
                if (enderecoClientePorTipoEnderecos != null)
                {
                    return enderecoClientePorTipoEnderecos;
                }
                else
                {
                    return enderecoClientePorTipoEnderecos;
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