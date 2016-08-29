using System;
using System.Collections.Generic;
using System.Linq;
using SalaoDoPantcho.Domain.IContracts.IContractsInfraEstructure.IContractsSGBD.IContractsSGBDEntity.IContractsSGBDServicos;
using SalaoDoPantcho.SGBD.Repository.RepositoryBases;
using SalaoDoPantcho.Entity.Sistema.Entity;
using SalaoDoPantcho.Entity.Sistema.Enum;

namespace SalaoDoPantcho.SGBD.Repository.RepositoryEntity.RepositoryServicos
{
    public class RepositoryServico : RepositoryBase<Servicos, Int32>, IContractsSGBDServico
    {
        #region Implementação Métodos Persistentes

        public ICollection<Servicos> PesquisarServicosPorGeneroPersistence(GeneroServico generoServico)
        {
            if (generoServico != 0)
            {
                try
                {
                    List<Servicos> servicoPorGenero = dataContext.Servicos.AsParallel()
                                                      .Where(servico => servico.GeneroServico == generoServico)
                                                      .ToList();
                    if (servicoPorGenero != null)
                    {
                        dataContext.Dispose();
                        return servicoPorGenero;
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

        public ICollection<Servicos> PesquisarServicosPorPrecoPersistence(decimal preco)
        {
            if (preco != decimal.Zero)
            {
                try
                {
                    List<Servicos> servicoPorPreco = dataContext.Servicos.AsParallel()
                                                     .Where(servico => servico.Preco == preco)
                                                     .ToList();
                    if (servicoPorPreco != null)
                    {
                        dataContext.Dispose();
                        return servicoPorPreco;
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

        public Servicos PesquisarServicosPorNomePersistence(string nome)
        {
            if (!string.IsNullOrEmpty(nome))
            {
                try
                {
                    Servicos servicoPorNome = dataContext.Servicos.AsParallel()
                                              .Where(servico => servico.Nome == nome)
                                              .FirstOrDefault();
                    if (servicoPorNome != null)
                    {
                        dataContext.Dispose();
                        return servicoPorNome;
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