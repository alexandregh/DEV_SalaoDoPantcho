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
            try
            {
                Promocoes promocaoPorNome = this.dataContext.Promocoes.AsNoTracking().Where(promocao => promocao.Nome == nome).FirstOrDefault();
                if (promocaoPorNome != null)
                {
                    this.dataContext.Dispose();
                    return promocaoPorNome;
                }
                else
                {
                    this.dataContext.Dispose();
                    return promocaoPorNome;
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

        public ICollection<Promocoes> PesquisarPromocoesPorDataInicioPersistence(DateTime dataInicio)
        {
            try
            {
                List<Promocoes> promocaoPorDataInicio = this.dataContext.Promocoes.AsNoTracking().Where(promocao => promocao.DataInicio == dataInicio).ToList();
                if (promocaoPorDataInicio != null)
                {
                    this.dataContext.Dispose();
                    return promocaoPorDataInicio;
                }
                else
                {
                    this.dataContext.Dispose();
                    return promocaoPorDataInicio;
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

        public ICollection<Promocoes> PesquisarPromocoesPorDataFimPersistence(DateTime dataFim)
        {
            try
            {
                List<Promocoes> promocaoPorDataFim = this.dataContext.Promocoes.AsNoTracking().Where(promocao => promocao.DataFim == dataFim).ToList();
                if (promocaoPorDataFim != null)
                {
                    this.dataContext.Dispose();
                    return promocaoPorDataFim;
                }
                else
                {
                    this.dataContext.Dispose();
                    return promocaoPorDataFim;
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

        public ICollection<Promocoes> PesquisarPromocoesPorDataInicioFimPersistence(DateTime dataInicio, DateTime dataFim)
        {
            try
            {
                List<Promocoes> promocaoPorDataInicioFim = this.dataContext.Promocoes.AsNoTracking().Where(promocao => promocao.DataInicio == dataInicio && promocao.DataFim == dataFim).ToList();
                if (promocaoPorDataInicioFim != null)
                {
                    this.dataContext.Dispose();
                    return promocaoPorDataInicioFim;
                }
                else
                {
                    this.dataContext.Dispose();
                    return promocaoPorDataInicioFim;
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