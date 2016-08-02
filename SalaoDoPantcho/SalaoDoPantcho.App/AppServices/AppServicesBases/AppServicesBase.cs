using System;
using System.Collections.Generic;
using SalaoDoPantcho.App.IContractsAppServices.IContractsAppServicesBases;
using SalaoDoPantcho.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesBases;

namespace SalaoDoPantcho.App.AppServices.AppServicesBases
{
    public abstract class AppServicesBase<TEntity, TKey> : IContractsAppServicesBase<TEntity, TKey> where TEntity : class
                                                                                                    where TKey : struct
    {
        #region Atributo

        private IContractsDomainServicesBase<TEntity, TKey> appServicesBase;

        #endregion

        #region Construtor

        public AppServicesBase(IContractsDomainServicesBase<TEntity, TKey> appServicesBase)
        {
            this.appServicesBase = appServicesBase;
        }

        #endregion

        #region Implementação Métodos Aplicação

        public void AppServicesInserir(TEntity entidade)
        {
            this.appServicesBase.InserirService(entidade);
        }

        public void AppServicesAtualizar(TEntity entidade)
        {
            this.appServicesBase.AtualizarService(entidade);
        }

        public void AppServicesExcluir(TEntity entidade)
        {
            this.appServicesBase.ExcluirService(entidade);
        }

        public ICollection<TEntity> AppServicesPesquisarTodos()
        {
            return this.appServicesBase.PesquisarTodosService();
        }

        public TEntity AppServicesPesquisarPorId(int id)
        {
            return this.appServicesBase.PesquisarPorIdService(id);
        }

        #endregion
    }
}