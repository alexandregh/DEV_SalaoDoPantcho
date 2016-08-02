using System;
using System.Collections.Generic;
using SalaoDoPantcho.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesBases;
using SalaoDoPantcho.Domain.IContracts.IContractsInfraEstructure.IContractsSGBD.IContractsSGBDBases;

namespace SalaoDoPantcho.Domain.DomainServices.DomainServicesBases
{
    public abstract class DomainServicesBase<TEntity, TKey> : IContractsDomainServicesBase<TEntity, TKey> where TEntity : class
                                                                                                          where TKey : struct
    {
        #region Atributo

        private IContractsSGBDBase<TEntity, TKey> servicoBase;

        #endregion

        #region Construtor

        public DomainServicesBase(IContractsSGBDBase<TEntity, TKey> servicoBase)
        {
            this.servicoBase = servicoBase;
        }

        #endregion

        #region Implementação Métodos Servicos

        public void InserirService(TEntity entidade)
        {
            try
            {
                servicoBase.InserirPersistence(entidade);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AtualizarService(TEntity entidade)
        {
            try
            {
                servicoBase.AtualizarPersistence(entidade);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void ExcluirService(TEntity entidade)
        {
            try
            {
                servicoBase.ExcluirPersistence(entidade);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ICollection<TEntity> PesquisarTodosService()
        {
            try
            {
                return servicoBase.PesquisarTodosPersistence();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public TEntity PesquisarPorIdService(Int32 id)
        {
            try
            {
                return servicoBase.PesquisarPorIdPersistence(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion
    }
}