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
            try
            {
                List<Servicos> servicoPorGenero = this.dataContext.Servicos.AsNoTracking().Where(servico => servico.GeneroServico == generoServico).ToList();
                if (servicoPorGenero != null)
                {
                    this.dataContext.Dispose();
                    return servicoPorGenero;
                }
                else
                {
                    this.dataContext.Dispose();
                    return servicoPorGenero;
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

        public ICollection<Servicos> PesquisarServicosPorPrecoPersistence(decimal preco)
        {
            try
            {
                List<Servicos> servicoPorPreco = this.dataContext.Servicos.AsNoTracking().Where(servico => servico.Preco == preco).ToList();
                if (servicoPorPreco != null)
                {
                    this.dataContext.Dispose();
                    return servicoPorPreco;
                }
                else
                {
                    this.dataContext.Dispose();
                    return servicoPorPreco;
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

        public Servicos PesquisarServicosPorNomePersistence(string nome)
        {
            try
            {
                Servicos servicoPorNome = this.dataContext.Servicos.AsNoTracking().Where(servico => servico.Nome == nome).FirstOrDefault();
                if (servicoPorNome != null)
                {
                    this.dataContext.Dispose();
                    return servicoPorNome;
                }
                else
                {
                    this.dataContext.Dispose();
                    return servicoPorNome;
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