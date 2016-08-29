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
            servicoBase.InserirPersistence(entidade);
        }

        public void AtualizarService(TEntity entidade)
        {
            servicoBase.AtualizarPersistence(entidade);
        }

        public void ExcluirService(TEntity entidade)
        {
            servicoBase.ExcluirPersistence(entidade);
        }

        public ICollection<TEntity> PesquisarTodosService()
        {
            return servicoBase.PesquisarTodosPersistence();
        }

        public TEntity PesquisarPorIdService(Int32 id)
        {
            return servicoBase.PesquisarPorIdPersistence(id);
        }

        #endregion
    }
}