using System;
using System.Collections.Generic;
using System.Linq;
using SalaoDoPantcho.Domain.IContracts.IContractsInfraEstructure.IContractsSGBD.IContractsSGBDEntity.IContractsSGBDPromocoes;
using SalaoDoPantcho.SGBD.Repository.RepositoryBases;
using SalaoDoPantcho.Entity.Sistema.Entity;

namespace SalaoDoPantcho.SGBD.Repository.RepositoryEntity.RepositoryPromocoes
{
    public class RepositoryPromocao : RepositoryBase<Promocoes, Int32>, IContractsSGBDPromocao
    {
        #region Implementação Métodos Persistentes

        public Promocoes PesquisarPromocaoPorNomePersistence(string nome)
        {
            if(!string.IsNullOrEmpty(nome))
            {
                try
                {
                    Promocoes promocaoPorNome = dataContext.Promocoes.AsParallel()
                                                .Where(promocao => promocao.Nome == nome)
                                                .FirstOrDefault();
                    if (promocaoPorNome != null)
                    {
                        dataContext.Dispose();
                        return promocaoPorNome;
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

        public ICollection<Promocoes> PesquisarPromocoesPorDataInicioPersistence(DateTime dataInicio)
        {
            if (dataInicio != null)
            {
                try
                {
                    List<Promocoes> promocaoPorDataInicio = dataContext.Promocoes.AsParallel()
                                                            .Where(promocao => promocao.DataInicio == dataInicio)
                                                            .ToList();
                    if (promocaoPorDataInicio != null)
                    {
                        dataContext.Dispose();
                        return promocaoPorDataInicio;
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

        public ICollection<Promocoes> PesquisarPromocoesPorDataFimPersistence(DateTime dataFim)
        {
            if (dataFim != null)
            {
                try
                {
                    List<Promocoes> promocaoPorDataFim = dataContext.Promocoes.AsParallel()
                                                        .Where(promocao => promocao.DataFim == dataFim)
                                                        .ToList();
                    if (promocaoPorDataFim != null)
                    {
                        dataContext.Dispose();
                        return promocaoPorDataFim;
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

        public ICollection<Promocoes> PesquisarPromocoesPorDataInicioFimPersistence(DateTime dataInicio, DateTime dataFim)
        {
            if (dataInicio != null && dataFim != null)
            {
                try
                {
                    List<Promocoes> promocaoPorDataInicioFim = dataContext.Promocoes.AsParallel()
                                                               .Where(promocao => promocao.DataInicio == dataInicio && promocao.DataFim == dataFim)
                                                               .ToList();
                    if (promocaoPorDataInicioFim != null)
                    {
                        dataContext.Dispose();
                        return promocaoPorDataInicioFim;
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